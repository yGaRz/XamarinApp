using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Essentials;

namespace XamarinApp.ServerSettings
{
    class ServerSettingsModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, args);
        }

        private static ServerSettingsModel instance;
        public static ServerSettingsModel Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServerSettingsModel();
                return instance;
            }
        }
        public ServerSettingsModel() {
            LoadFromProperties();
        }

        private string _url;
        public string url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged(new PropertyChangedEventArgs("url"));
            }
        }
        private string _gwtTocken;
        public string gwtTocken
        {
            get { return _gwtTocken; }
            set 
            { 
                _gwtTocken = value;
                OnPropertyChanged(new PropertyChangedEventArgs("gwtTocken"));
            }
        }

        public void SaveToProperties()
        {
            if (url != null)
                Preferences.Set("url", url);
            if (gwtTocken != null)
                Preferences.Set("gwttocken", gwtTocken);
        }

        public void LoadFromProperties()
        {
            object str = "";
            url = Preferences.Get("url","");
            gwtTocken = Preferences.Get("gwttocken", "");
        }


    }
}
