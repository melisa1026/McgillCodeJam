using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Interaction logic for LandlordTennantsPage.xaml
    /// </summary>
    public partial class LandlordTennantsPage : Page
    {
        public LandlordTennantsPage()
        {
            InitializeComponent();
        }

        private void downloadEmployerLetter_Click(object sender, RoutedEventArgs e)
        {
            bool downloadSucess = true;

            try
            {
                using (WebClient Client = new WebClient())
                    Client.DownloadFile("../../../PotatoEmployer.pdf", "LetterFromEmployer.pdf");
            }
            catch (Exception exception)
            {
                MessageBox.Show("There is no Employer Letter for this tenant.");
                downloadSucess = false;

            }

            if(downloadSucess)
                MessageBox.Show("File Downloaded!");
        }

        private void downloadPayStubs_Click(object sender, RoutedEventArgs e)
        {
            bool downloadSucess = true;

            try
            {
                using (WebClient Client = new WebClient())
                    Client.DownloadFile("", "LetterFromEmployer.pdf");
            }
            catch (Exception exception)
            {
                MessageBox.Show("There are no Pay Stubs for this tenant.");
                downloadSucess = false;
            }

            if (downloadSucess)
                MessageBox.Show("File Downloaded!");
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
