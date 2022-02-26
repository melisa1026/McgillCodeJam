using Microsoft.Win32;
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
    /// Interaction logic for TenantPage.xaml
    /// </summary>
    public partial class TenantPage : Page
    {
        public TenantPage()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
        }


        private void Upload_Click(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.OpenFileDialog openFileDialog = new OpenFileDialog();

            bool? response = openFileDialog.ShowDialog();

            if (response == true)
            {
                string filepath = openFileDialog.FileName;
                MessageBox.Show(filepath);
            }
        }

        private void toLoginPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
        }
    }
}
