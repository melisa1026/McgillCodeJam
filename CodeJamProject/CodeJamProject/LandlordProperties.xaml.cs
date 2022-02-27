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
    /// Interaction logic for LandloardProperties.xaml
    /// </summary>
    public partial class LandloardProperties : Page
    {
        public LandloardProperties()
        {
            InitializeComponent();

            generateAddresses();
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

        private void generateAddresses()
        {
            string[] addresses = new string[3];
            addresses[0] = "123 Fishmish";
            addresses[1] = "0004 Mashed-Potatow Avenue";
            addresses[2] = "19583 Lasso Lany";
            StackPanel? grid = this.FindName("gridTag") as StackPanel;

            int[] prices = new int[3];
            prices[0] = 20000;
            prices[1] = 1000000000;
            prices[2] = 459000;

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
        }
    }
}

/*
    < TextBlock Text = "Address: "
                   Foreground = "White"
                   FontSize = "15"
                   FontWeight = "Medium"
                   Margin = "20, 0, 0, 0" />
*/