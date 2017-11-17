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
    /// Interaction logic for AddPerson.xaml
    /// </summary>
    public partial class AddPerson : Window
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            //verify contents!            
            if (Session.ExistsPersonWithName(nameTxt.Text))
            {
                MessageBoxCreator.RaiseWarning("Naam bestaat al.");
                return;
            }

            if (nameTxt.Text.Length < 3)
            {
                MessageBoxCreator.RaiseWarning("Naam te kort");
                return;
            }

            if (passwordTxt.Password.Length < 3)
            {
                MessageBoxCreator.RaiseWarning("Wachtwoord te kort");
                return;
            }

            if (!passwordTxt.Password.Equals(password2Txt.Password))
            {
                MessageBoxCreator.RaiseWarning("Wachtwoorden komen niet overeen.");
                return;
            }

            Person p = new Person(nameTxt.Text, scancodeTxt.Text, passwordTxt.Password);

            Session.Persons.Add(p);

            DialogResult = true;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            nameTxt.Focus();
        }
    }
}
