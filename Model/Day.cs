using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model
{
    public class Day
    {
        public string Datetime { get; set; }
        public int DatetimeEpoch { get; set; }
        public float Tempmax { get; set; }
        public float Tempmin { get; set; }
        public float Temp { get; set; }
        public float Feelslikemax { get; set; }
        public float Feelslikemin { get; set; }
        public float Feelslike { get; set; }
        public float Dew { get; set; }
        public float Humidity { get; set; }
        public float Precip { get; set; }
        public float Precipprob { get; set; }
        public float Precipcover { get; set; }
        public string[] Preciptype { get; set; }
        public float Snow { get; set; }
        public float Snowdepth { get; set; }
        public float Windgust { get; set; }
        public float Windspeed { get; set; }
        public float Winddir { get; set; }
        public float Pressure { get; set; }
        public float Cloudcover { get; set; }
        public float Visibility { get; set; }
        public float Solarradiation { get; set; }
        public float Solarenergy { get; set; }
        public float Uvindex { get; set; }
        public float Severerisk { get; set; }
        public string Sunrise { get; set; }
        public int SunriseEpoch { get; set; }
        public string Sunset { get; set; }
        public int SunsetEpoch { get; set; }
        public float Moonphase { get; set; }
        public string Conditions { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string[] Stations { get; set; }
        public string Source { get; set; }
    }
}
