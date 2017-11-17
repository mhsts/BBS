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
    /// Interaction logic for OrderListLine.xaml
    /// </summary>
    public partial class OrderListLine : UserControl
    {
        public OrderListLine()
        {
            InitializeComponent();
        }

        public OrderListLine(ProductOrder orderLine, Action<ProductOrder> onDelete)
        {
            InitializeComponent();
            label1.Content = orderLine.ToFriendlyString();
            deleteButton.MouseUp += (s, e) => onDelete(orderLine);
        }

        public new object Content
        {
            get { return label1.Content; }
            set { label1.Content = value; }
        }
    }
}
