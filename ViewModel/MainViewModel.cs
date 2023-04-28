using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using WeatherApp.Model;
using WeatherApp.ViewModel.UserControls;
using System.Windows.Controls;
using WeatherApp.View.UserControls;

namespace WeatherApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Fields       
        private SettingsWindowViewModel settingsWindowViewModel = new SettingsWindowViewModel();
        private MainUserControlViewModel mainUserControlViewModel = new MainUserControlViewModel();       
        private UserControl userControl;
        #endregion

        #region Properties
        public UserControl UserControl
        {
            get { return userControl; }
            set
            {
                userControl = value;
                RaisePropertyChanged(nameof(UserControl));
            }
        }
        #endregion
        #region Commands        
        public ICommand SetSettingView { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            settingsWindowViewModel.mainWindowMethods += OnItemSelected;
            mainUserControlViewModel.mainWindowMethods += OnItemSelected;

            UserControl = new SettingWindow { DataContext = settingsWindowViewModel};           
            SetSettingView = new RelayCommand(new Action<object>(OpenSettings));

        }
        #endregion

        #region Methods
        private void OpenSettings(object obj)
        {

            if (UserControl.GetType() == typeof(MainUserControl))
                UserControl = new SettingWindow { DataContext = settingsWindowViewModel };
            else
                UserControl = new MainUserControl { DataContext = mainUserControlViewModel };
        }

        private void OnItemSelected()
        {
            mainUserControlViewModel.api = settingsWindowViewModel.api;
            UserControl = new MainUserControl { DataContext = mainUserControlViewModel};
        }
        #endregion
    }
}
