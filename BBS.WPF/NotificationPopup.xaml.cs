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
using System.Windows.Threading;

namespace BBS.WPF
{
    /// <summary>
    /// Interaction logic for NotificationPopup.xaml
    /// </summary>
    public partial class NotificationPopup : Window
    {
        public NotificationPopup()
        {
            InitializeComponent();
            
            this.Loaded += new RoutedEventHandler(NotificationPopup_Loaded);
        }

        void NotificationPopup_Loaded(object sender, RoutedEventArgs e)
        {
            var workingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            var transform = PresentationSource.FromVisual(this).CompositionTarget.TransformFromDevice;
            var corner = transform.Transform(new Point(workingArea.Right, workingArea.Bottom));

            this.Left = corner.X - this.ActualWidth;
            this.Top = corner.Y - this.ActualHeight;
        }

        private void DoubleAnimationUsingKeyFrames_Completed(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void AddLine(string line)
        {
            AddLine(line, false);
        }

        internal void AddLine(string line, bool bold)
        {
            var textblock = new TextBlock();

            if (bold)
            {
                textblock.Inlines.Add(new Bold(new Run(line)));
            }
            else
            {
                textblock.Text = line;
            }

            contentPanel.Children.Add(textblock);
        }
    }
}
