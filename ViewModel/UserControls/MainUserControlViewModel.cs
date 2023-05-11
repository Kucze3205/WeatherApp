using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WeatherApp.Model;
using System.IO;
using System.Runtime.CompilerServices;

namespace WeatherApp.ViewModel.UserControls
{
    public class MainUserControlViewModel : ViewModelBase
    {
        #region Fields 
        public string api;
        public MainWindowMethods mainWindowMethods;
        #endregion

        #region Properties
        public Weather Weather { get; set; } = null;
        public Day First { get; set; }
        #endregion

        #region Commands
        public ICommand Loaded { get; set; }

        #endregion

        #region Constructor
        public MainUserControlViewModel()
        {
            Loaded = new RelayCommand(new Action<object>(LoadedV));
        }
        #endregion

        #region Private methods
        private void ReloadLastWeather()
        {
            Weather = JsonConvert.DeserializeObject<Weather>(File.ReadAllText(@"lastCityWeather.json"));
            First = Weather.Days[0];
            RaisePropertyChanged(nameof(First));
            Weather.Days.RemoveAt(0);
            RaisePropertyChanged(nameof(Weather));
        }

        private void LoadedV(object obj)
        {

            try
            {
                WebClient client = new WebClient();
                string reply = client.DownloadString(api);
                File.WriteAllText(@"lastCityWeather.json", reply);
                Weather = JsonConvert.DeserializeObject<Weather>(reply);
                First = Weather.Days[0];
                RaisePropertyChanged(nameof(First));
                Weather.Days.RemoveAt(0);
                RaisePropertyChanged(nameof(Weather));
            }
            catch (Exception ex)
            {
                
                MessageBoxViewModel messageBoxViewModel = new MessageBoxViewModel();
                View.MessageBox messageBox = new View.MessageBox { DataContext = messageBoxViewModel };

                messageBoxViewModel.MessageType = "error";
                messageBoxViewModel.Message = ex.Message;
                messageBoxViewModel.button1Method += mainWindowMethods;
                messageBoxViewModel.button1Method += messageBox.Close;
                messageBoxViewModel.button2Method += ReloadLastWeather;
                messageBoxViewModel.button2Method += messageBox.Close;

                messageBox.ShowDialog();
            }        
            #endregion
        }
        
    }
}
