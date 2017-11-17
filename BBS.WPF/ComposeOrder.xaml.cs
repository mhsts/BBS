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

namespace BBS.WPF
{
    /// <summary>
    /// Interaction logic for ComposeOrder.xaml
    /// </summary>
    public partial class ComposeOrder : UserControl, IInitView
    {
        private ScreenTransitionAnimator animator;

        public ComposeOrder()
        {
            InitializeComponent();
            animator = new ScreenTransitionAnimator(productChoice, leftGrid);
            orderList.OrderUpdated = OnOrderUpdated;
        }

        void IInitView.Init()
        {
            productChoice.Visibility = Visibility.Visible;
            amountChoice.Visibility = Visibility.Hidden;

            InitProducts();
            InitAmounts();

            Person currentUser = Session.GetCurrentUser();

            if (currentUser != null)
            {
                if (!currentUser.HasCurrentMutation())
                    order = currentUser.CreateNewOrder();
            }

            orderList.Update(order);
        }

        private void InitProducts()
        {
            var factor = DPIManager.GetDPIFactor(this);

            leftGrid.Width = 875 / factor;

            productChoice.Children.Clear();

            var productGroups = Stock.Products
                .Where(p => p.Active)
                .OrderByDescending(p => p.InternalCount)
                .GroupBy(p => p.Category)
                .Where(group => group.Count() > 0)
                .OrderBy(group => GetProductOrdering(group.Key));

            foreach (var productGroup in productGroups)
            {
                var category = productGroup.Key;

                productChoice.Children.Add(new Label() { Width = leftGrid.ActualWidth - 10, Content = Enum.GetName(typeof(ProductCategory), category) });

                foreach (var product in productGroup)
                {
                    var button = new Button() { Content = product.Name, Tag = product, Width = 162 / factor, Height = 50 / factor };
                    button.Click += (s, e) => OnProductSelected((Product)((Button)s).Tag);
                    button.FontSize /= factor;
                    productChoice.Children.Add(button);
                }
            }
        }
        
        private int GetProductOrdering(ProductCategory productCategory)
        {
            if (productCategory == ProductCategory.Overige)
            {
                return Enum.GetValues(productCategory.GetType()).Length;
            }
            else
            {
                return (int)productCategory;
            }
        }

        private void InitAmounts()
        {
            var factor = DPIManager.GetDPIFactor(this);

            amountChoiceContainer.Children.Clear();

            for (int amount = 1; amount <= 33; amount++)
            {
                var button = new Button() { Content = amount, Tag = amount, Width = 205 / factor, Height = 65 / factor };
                button.Click += (s, e) => OnAmountSelected((int)((Button)s).Tag);
                if (amount % 11 == 0)
                {
                    var meters = amount / 11;
                    button.Width *= 2;
                    button.Width += 10;
                    button.Content = String.Format("{0} ({1} meter)", amount, meters);
                }
                amountChoiceContainer.Children.Add(button);
            }
        }

        private Order order;
        private ProductOrder currProductOrder;

        private void OnProductSelected(Product product)
        {
            currProductOrder = new ProductOrder((Product)product);
            animator.GotoScreen(amountChoice, Direction.Forward);            
        }

        private void AmountBackButtonClick(object sender, RoutedEventArgs e)
        {
            animator.GotoScreen(productChoice, Direction.Backward);
        }

        private void OnAmountSelected(int amount)
        {
            if (currProductOrder == null)
                return;

            currProductOrder.SetAmount(amount);
            order.AddProductOrder(currProductOrder);
            
            orderList.Update(order); //triggers OnOrderUpdated
            currProductOrder = null;
            animator.GotoScreen(productChoice, Direction.Forward);
        }

        private void OnOrderUpdated()
        {
            totalLabel.Content = String.Format("Totaal: € {0:0.00}", order.GetCost());

            if (Session.GetCurrentUser() is ContantPerson)
            {
                balanceLabel.Foreground = Brushes.Red;
                balanceLabel.Content = "Cash";
            }
            else
            {
                Decimal bal = Session.GetCurrentUser().Balance;
                balanceLabel.Content = String.Format("Tegoed: € {0:0.00}", bal);
                if (bal < 0m)
                    balanceLabel.Foreground = Brushes.Red;
                else
                    balanceLabel.Foreground = Brushes.Black;
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (Session.GetCurrentUser() != null)
            {
                Session.GetCurrentUser().AbortMutation();
            }
            //send event?
            ExitOrdersScreen(false);
        }

        private void ExitOrdersScreen(bool success)        
        {
            if (OrderDone != null)
            {
                OrderDone(success, order);
            }
            order = null;
            currProductOrder = null;

            if (productChoice.Visibility != Visibility.Visible)
            {
                animator.GotoScreen(productChoice, Direction.Backward);
            }
        }

        public Action<bool, Order> OrderDone;

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            if (Session.GetCurrentUser() is ContantPerson)
                MessageBox.Show("Vergeet niet cash te betalen!");

            if (Session.GetCurrentUser().CommitMutation())
                ExitOrdersScreen(true);
            else
                ExitOrdersScreen(false);
        }
    }
}
