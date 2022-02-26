using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeJamProject
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        
        public LoginPage()
        {
            
            InitializeComponent();
        }

        private void signInButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Password;

            //implement a search through database for this username
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {           
            NavigationService.Navigate(new Uri("SignupPage.xaml", UriKind.Relative));
        }
    }
}
