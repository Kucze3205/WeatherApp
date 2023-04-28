using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WeatherApp.Model;


namespace WeatherApp.ViewModel
{
    public class MessageBoxViewModel : ViewModelBase
    {
        #region Fields       
        private string messageType;
        private string message;       
        public MainWindowMethods button1Method;
        public MainWindowMethods button2Method;

        #endregion

        #region Properties
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                RaisePropertyChanged(nameof(Message));
            }
        }
        public string MessageType
        {
            get { return messageType; }
            set 
            {
                messageType = value;
                RaisePropertyChanged(nameof(MessageType));
            }
        }

        #endregion

        #region Commands
        public ICommand Button1_click { get; set; }
        public ICommand Button2_click { get; set; }
        #endregion

        #region Constructor

        public MessageBoxViewModel()
        {
            Button1_click = new RelayCommand(new Action<object>(Button1));
            Button2_click = new RelayCommand(new Action<object>(Button2));
        }
        

        #endregion

        #region Methods
        private void Button1(object obj)
        {
            if(messageType == "error")
            {
                button1Method();
                //CurrentScreen = new MainUserControlViewModel(settingsWindowViewModel.api);
                //messageBox.Close();
            }
        }

        private void Button2(object obj)
        {
            if (messageType == "error")
            {
                button2Method();
                //
                //
            }
        }       
        #endregion
    }
}
