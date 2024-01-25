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

namespace PracticeAPI.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void London_Btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LondonPage());
        }

        private void NewYork_Btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewYorkPage());
        }

        private void LosAngeles_Btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LosAngelesPage());
        }

        private void Toronto_Btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TorontoPage());
        }

        private void Berlin_Btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BerlinPage());
        }

        private void Paris_Btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ParisPage());
        }
    }
}
