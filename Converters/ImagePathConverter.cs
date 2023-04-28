using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.IO;

namespace WeatherApp.Converters
{
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value?.ToString())
            {
                case "clear-day": { return "/Graphics/clear-day.png"; }
                case "clear-night": { return "/Graphics/clear-night.png"; }
                case "cloudy": { return "/Graphics/cloudy.png"; }
                case "fog": { return "/Graphics/fog.png"; }
                case "hail": { return "/Graphics/hail.png"; }
                case "partly-cloudy-day": { return "/Graphics/partly-cloudy-day.png"; }
                case "partly-cloudy-night": { return "/Graphics/partly-cloudy-night.png"; }
                case "rain-snow-showers-day": { return "/Graphics/rain-snow-showers-day.png"; }
                case "rain-snow-showers-night": { return "/Graphics/rain-snow-showers-night.png"; }
                case "rain-snow": { return "/Graphics/rain-snow.png"; }
                case "rain": { return "/Graphics/rain.png"; }
                case "showers-day": { return "/Graphics/showers-day.png"; }
                case "showers-night": { return "/Graphics/showers-night.png"; }
                case "snow-showers-day": { return "/Graphics/snow-showers-day.png"; }
                case "snow-showers-night": { return "/Graphics/snow-showers-night.png"; }
                case "snow": { return "/Graphics/snow.png"; }
                case "thunder-rain": { return "/Graphics/thunder-rain.png"; }
                case "thunder-showers-day": { return "/Graphics/thunder-showers-day.png"; }
                case "thunder-showers-night": { return "/Graphics/thunder-showers-night.png"; }
                case "thunder": { return "/Graphics/thunder.png"; }
                case "wind": { return "/Graphics/wind.png"; }
                case "error": { return "/Graphics/299045_sign_error_icon.png"; }
                default: { return "/Graphics/3044691_app_essential_interface_question_ui_icon.png"; }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
