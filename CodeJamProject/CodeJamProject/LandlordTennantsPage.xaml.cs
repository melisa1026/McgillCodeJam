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

            // generateTenants();
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

        /*private void generateTenants()
        {
            
            StackPanel? grid = this.FindName("gridTag") as StackPanel;

            string[] names = new string[4];
            names[0] = "Melisa";
            names[1] = "Julien";
            names[2] = "Kevin";
            names[4] = "Ron";

            int[] incomes = new int[4];
            incomes[0] = 2;
            incomes[1] = 1000000000;
            incomes[2] = -1;
            incomes[3] = 100000;

            int[] sinNums = new int[4];
            sinNums[0] = 930433944;
            sinNums[1] = 738493294;
            sinNums[2] = 338748288;
            sinNums[3] = 399400233;

            int[] creditScore = new int[4];
            creditScore[0] = 701;
            creditScore[1] = 801;
            creditScore[2] = 901;
            creditScore[3] = 1001;

            string[] movingDate = new string[4];
            movingDate[0] = "Fall";
            movingDate[1] = "Spring";
            movingDate[2] = "Summer";
            movingDate[3] = "Winter";

            int[] numResidents = new int[4];
            numResidents[0] = 0;
            numResidents[1] = 1;
            numResidents[2] = 2;
            numResidents[3] = 3;


            for (int i = 0; i < addresses.Length; i++)
            {
                TextBlock addressText = new TextBlock();
                addressText.Text = "Address: " + addresses[i];
                TextBlock priceText = new TextBlock();
                priceText.Text = "Price: $" + prices[i];

                addressText.FontSize = 15;
                addressText.Foreground = Brushes.White;
                addressText.FontWeight = FontWeights.Medium;
                addressText.Margin = new Thickness(20, 0, 0, 0);

                priceText.FontSize = 15;
                priceText.Foreground = Brushes.White;
                priceText.FontWeight = FontWeights.Medium;
                priceText.Margin = new Thickness(20, 0, 0, 20);

                if (grid != null)
                {
                    grid.Children.Add(addressText);
                    grid.Children.Add(priceText);
                }
            }
        }*/


    }

}
