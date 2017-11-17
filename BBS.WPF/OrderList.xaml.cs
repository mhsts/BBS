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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        public OrderList()
        {
            InitializeComponent();
        }
        private Order currentOrder;

        public void Update(Order order)
        {
            currentOrder = order;

            FillScreen();

            FireOrderUpdated();
        }

        private void FillScreen()
        {
            if (currentOrder == null)
                return;

            stack.BeginInit();

            stack.Children.Clear();

            foreach (var line in currentOrder.ProductOrders)
            {
                stack.Children.Add(new OrderListLine(line, (x) => OnDelete(x)));
            }

            stack.EndInit();
        }

        public void OnDelete(ProductOrder orderLine)
        {
            currentOrder.RemoveProductOrder(orderLine);

            FillScreen();

            FireOrderUpdated();
        }

        public void FireOrderUpdated()
        {
            if (OrderUpdated != null)
            {
                OrderUpdated();
            }
        }

        public Action OrderUpdated;
    }
}
