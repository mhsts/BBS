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
using System.Windows.Interop;

namespace BBS.WPF
{
    /// <summary>
    /// Interaction logic for SelectUser.xaml
    /// </summary>
    public partial class SelectUser : UserControl, IInitView
    {
        public SelectUser()
        {
            InitializeComponent();
        }

        public void Init()
        {
            var factor = DPIManager.GetDPIFactor(this);

            Buttons.Children.Clear();
            foreach (var person in Session.Persons.Where(p=>p.ShowToUser()))
            {
                var width = 180 / factor;
                var height = 55 / factor;                
                var button = new Button() { Content = person.Name, Tag = person, Width = width, Height = height };
                button.FontSize /= factor;
                button.Click += new RoutedEventHandler(buttonClick);
                Buttons.Children.Add(button);
            }
        }

        void buttonClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var person = button.Tag as Person;

            if (UserSelected != null)
            {
                UserSelected(person);
            }
        }

        public Action<Person> UserSelected;
    }

    public static class DPIManager
    {
        public static double GetDPIFactor(Control c)
        {
            var window = Window.GetWindow(c);
            return GetDPIFactor(window);
        }

        public static double GetDPIFactor(Window window)
        {
            // get the handle of the window
            HwndSource windowhandlesource = (HwndSource)PresentationSource.FromVisual(window);
            // work out the current screen's DPI
            Matrix screenmatrix = windowhandlesource.CompositionTarget.TransformToDevice;
            double dpiX = screenmatrix.M11;
            double dpiY = screenmatrix.M22;

            return dpiX;
        }
    }
}
