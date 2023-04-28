using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherApp;
using WeatherApp.Model;
using Newtonsoft.Json;
using System.IO;
using System.Collections.ObjectModel;

namespace WeatherApp.ViewModel.UserControls
{
    public class SettingsWindowViewModel : ViewModelBase
    {

        #region Fields
        private const int CitiesNum = 141000;
        private const int test = 100000;
        private const string apiBegin = "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/";
        private const string apiEnd = "?unitGroup=metric&include=days&key=STYM2WDSNM3Y34EAYESBU8AQ6&contentType=json";
        public string api;
        public MainWindowMethods mainWindowMethods;
        public Class1[] Cities;
        #endregion

        #region Properties

        public string SelectedCity { get; set; }
        
        public string[] CitiesNames { get; set; } = new string[test];

        #endregion

        #region Commands
        public ICommand Accept { get; set; }

        #endregion

        #region Constructor
        public SettingsWindowViewModel()
        {
           

            Accept = new RelayCommand(new Action<object>(Accepting));
            string path = File.ReadAllText("C:\\Users\\pc\\source\\repos\\WeatherApp\\cities.json");
            Cities = JsonConvert.DeserializeObject<Class1[]>(path);

            for (int i = 0; i < test; i++)
            {
                CitiesNames[i] = Cities[i].name;
            }

            
        }
        #endregion

        #region Private methods
        public void Accepting(object obj)
        {
            RaisePropertyChanged(nameof(SelectedCity));

            api = apiBegin;
            api += SelectedCity;
            api += apiEnd;

            mainWindowMethods();
        }
        #endregion
    }
}
