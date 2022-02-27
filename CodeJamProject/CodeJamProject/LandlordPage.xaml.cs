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
    /// Interaction logic for LandlordPage.xaml
    /// </summary>
    public partial class LandlordPage : Page
    {
        public LandlordPage()
        {
            InitializeComponent();
        }

        private void toLandlordTennants_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("LandlordTennantsPage.xaml", UriKind.Relative));
        }

        private void toLoginPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
        }

        private void toLandlordPropertiesPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("LandlordProperties.xaml", UriKind.Relative));
        }

        private void toLandlordPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("LandlordPage.xaml", UriKind.Relative));
        }
    }
}
