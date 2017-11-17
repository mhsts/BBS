using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Forms.Integration;
using BBS.View;

namespace BBS.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private ScreenTransitionAnimator animator;

        public Window1()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(Window1_Loaded);

            if (!Session.Load())
            {
                var backupRecovery = new BackupRecovery();
                backupRecovery.ShowDialog();
            }
            
            animator = new ScreenTransitionAnimator(selectUser, subScreens);

            CardReader cr = new CardReader(this);
            cr.Scanned = (bc) => 
            {
                if (Session.LogInUser(new ID(bc.Value, "")))
                {
                    currentUserLabel.Content = Session.GetCurrentUser().Name;
                    GotoOrders();
                }
            };

            const string titleFile = "BBS.dta";
            Title = File.Exists(titleFile) ? File.ReadAllText(titleFile) : "BBS v2.0 - Mr. van Daalgroep Boskoop";
        }

        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeInteractionFlow();
        }

        private void InitializeInteractionFlow()
        {
            Person currentPerson = null;

            selectUser.IsVisibleChanged += (s, e) =>
            {
                adminButton.Visibility = selectUser.Visibility;
                addPerson.Visibility = selectUser.Visibility;
                cashButton.Visibility = selectUser.Visibility;

                if (selectUser.Visibility == Visibility.Visible)
                {
                    currentUserLabel.Content = "";
                    currentUserLabel.Visibility = Visibility.Hidden;
                }
                else
                {
                    currentUserLabel.Visibility = Visibility.Visible;
                }
            };

            composeOrder.IsVisibleChanged += (s, e) =>
            {
                grolschLogo.Visibility = composeOrder.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
                viewLog.Visibility = composeOrder.Visibility;
                accountSettingsButton.Visibility = composeOrder.Visibility;
            };

            viewLog.MouseUp += (s, e) =>
            {
                ShowLogFor(currentPerson);
            };

            selectUser.UserSelected = (person) =>
            {
                currentPerson = person;
                currentUserLabel.Content = currentPerson.Name;
                animator.GotoScreen(loginUser, Direction.Forward);
            };
            loginUser.LoginAttempt = (passID) =>
            {
                if (Session.LogInUser(currentPerson, passID))
                {
                    GotoOrders();
                    return true;
                }
                return false;
            };
            loginUser.LoginCanceled = () =>
            {
                currentPerson = null;
                animator.GotoScreen(selectUser, Direction.Backward);
            };
            composeOrder.OrderDone = (success, order) =>
            {
                Session.LogOutCurrentUser();
                animator.GotoScreen(selectUser, success ? Direction.Forward : Direction.Backward);

                if (success)
                {
                    var popup = new NotificationPopup();
                    popup.AddLine("Laatste bestelling:", true);
                    popup.AddLine("");
                    foreach (var orderline in order.ProductOrders)
                    {
                        popup.AddLine(orderline.ToFriendlyString());
                    }
                    popup.Show();
                }
            };
            selectUser.Init();
        }

        private void GotoOrders()
        {
            animator.GotoScreen(composeOrder, Direction.Forward);
        }

        private void ShowLogFor(Person currentPerson)
        {
            var window = new Window();
            window.Title = string.Format("Geschiedenis voor {0}...", currentPerson.Name);
            window.ResizeMode = ResizeMode.NoResize;
            var textbox = new TextBox();
            textbox.IsReadOnly = true;
            textbox.VerticalAlignment = VerticalAlignment.Stretch;
            textbox.HorizontalAlignment = HorizontalAlignment.Stretch;
            textbox.Text = currentPerson.ToStringMutations();
            textbox.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            window.Content = textbox;
            window.Loaded += (s, e) =>
            {
                textbox.CaretIndex = textbox.Text.Length;
                textbox.ScrollToEnd();
            };
            window.ShowDialog();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Session.Exit())
                e.Cancel = true;
        }

        private void adminButton_Click(object sender, RoutedEventArgs e)
        {
            var adminLoginWindow = new AdminLoginWindow();
            adminLoginWindow.KeyPreview = true;
            adminLoginWindow.KeyUp += (s, ke) => { if (ke.KeyCode == System.Windows.Forms.Keys.Escape)adminLoginWindow.Close(); };
            adminLoginWindow.ShowDialog();

            var currentUser = Session.GetCurrentUser();

            if (currentUser != null && currentUser.IsBar())
            {
                ShowWinFormsControlInDialog(new AdminTabs(), "Bar betaal systeem - Admin gedeelte");
            }
            Session.LogOutCurrentUser();
        }

        private void ShowWinFormsControlInDialog(System.Windows.Forms.Control c, string title)
        {
            var host = new WindowsFormsHost();
            var window = CreatePopupWindow(title, true);            
            window.Content = host;
            host.Child = c;
            window.ShowDialog();
        }

        private Window CreatePopupWindow(string title, bool maximized)
        {
            var window = new Window();
            window.Title = title;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.WindowState = maximized ? WindowState.Maximized : WindowState.Normal;
            window.ResizeMode = ResizeMode.NoResize;
            window.ShowInTaskbar = false;
            return window;
        }

        private void addPerson_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var window = new AddPerson();            
            window.ShowDialog();
            selectUser.Init();
        }

        private void accountSettingsButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var currentUser = Session.GetCurrentUser();

            if (currentUser == null)
            {
                throw new InvalidOperationException("Expected a user to be logged in, found none");
            }

            var window = CreatePopupWindow("Kies een nieuwe touch login (één beweging zonder loslaten): sluit het scherm als je tevreden bent", false);
            var touchLogin = new TouchLogin();
            window.Content = touchLogin;

            touchLogin.OnTouchKeyEntered = (touchKey) => { currentUser.ID.TouchCode = touchKey; };

            window.ShowDialog();
        }

        private void cashButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Session.LogInUser(ContantPerson.GetID());
            currentUserLabel.Content = "(Contant betalen)";
            GotoOrders();
        }
    }
}
