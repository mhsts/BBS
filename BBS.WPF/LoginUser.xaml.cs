using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace BBS.WPF
{
    /// <summary>
    /// Interaction logic for LoginUser.xaml
    /// </summary>
    public partial class LoginUser : UserControl, IInitView
    {
        private static Storyboard passwordRedBlink;
        private static Storyboard touchRedBlink;

        public LoginUser()
        {
            InitializeComponent();

            passwordBox.Background = Brushes.White;
            passwordRedBlink = Blinker.PrepareFeedback(passwordBox, true);
            touchRedBlink = Blinker.PrepareFeedback(touchLogin, false);
            touchLogin.OnTouchKeyEntered += TouchLoginAttempt;
        }

        public Func<ID, bool> LoginAttempt;
        public Action LoginCanceled;

        private void buttonCancelClick(object sender, RoutedEventArgs e)
        {
            FireLoginCanceled();
        }

        private void FireLoginCanceled()
        {
            if (LoginCanceled != null)
            {
                LoginCanceled();
            }
        }

        private void TouchLoginAttempt(string touchkey)
        {
            var failed = !LoginAttempt(new ID("", "", touchkey));

            if (failed)
            {
                touchRedBlink.Begin();
            }
        }

        private void buttonOkClick(object sender, RoutedEventArgs e)
        {
            var failed = !LoginAttempt(new ID("", passwordBox.Password));  

            if (failed)
            {
                passwordRedBlink.Begin(); 

                passwordBox.Focus();
                passwordBox.SelectAll();
            }
        }

        private void passwordBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return || e.Key == Key.Enter)
            {
                buttonOkClick(passwordBox, new RoutedEventArgs());
            }
        }

        void IInitView.Init()
        {
            passwordBox.Password = "";
            passwordBox.Focus();
        }

        private void UserControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                FireLoginCanceled();
            }
        }
    }
}
