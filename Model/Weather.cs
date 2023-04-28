using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model
{
    public class Weather
    {
        public int QueryCost { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string ResolvedAddress { get; set; }
        public string Address { get; set; }
        public string Timezone { get; set; }
        public float Tzoffset { get; set; }
        public ObservableCollection<Day> Days { get; set; }
    }
}
