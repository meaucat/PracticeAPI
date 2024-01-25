using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAPI.Pages
{
    class WeatherResponse
    {
        public string Name { get; set; }
        public MainInfo Main { get; set; }
    }
    class MainInfo
    {
        public string Description { get; set; }
        public float Temp { get; set; }
    }
}
