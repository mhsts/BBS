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
using System.Windows.Shapes;

namespace BBS.WPF
{
    /// <summary>
    /// Interaction logic for ErrorWindow.xaml
    /// </summary>
    public partial class ErrorWindow : Window
    {
        public ErrorWindow()
        {
            InitializeComponent();
        }

        internal static void Show(string txt, string exceptionMsg)
        {
            var errorWindow = new ErrorWindow();
            errorWindow.errorLabel.Text = txt;
            errorWindow.detailLabel.Text = exceptionMsg;
            errorWindow.ShowDialog();
        }
    }
}
