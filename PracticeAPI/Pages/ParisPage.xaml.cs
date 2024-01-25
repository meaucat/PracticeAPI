using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace PracticeAPI.Pages
{
    /// <summary>
    /// Логика взаимодействия для ParisPage.xaml
    /// </summary>
    public partial class ParisPage : Page
    {
        public ParisPage()
        {
            InitializeComponent();
        }

        private void NameCityTB_Loaded(object sender, RoutedEventArgs e)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Paris&appid=4d91d68b8d17e237ab3e18bc452c86e0&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();
            NameCityTB.Text = response;

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            NameCityTB.Text = weatherResponse.Name;
            TemperatureTB.Text = weatherResponse.Main.Temp.ToString();
            DescriptionTB.Text = weatherResponse.Main.Description.ToString();
        }
    }
}
