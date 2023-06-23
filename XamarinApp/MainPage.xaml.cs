using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            buttonPostPage.Clicked += ToPostPage;
            buttonServerSettings.Clicked += ToServerSettingsPage;
        }

        private void ToPostPage(object sender, EventArgs e)
        {
            Navigation.PushAsync( new PostMessagePage());
        }

        private void ToServerSettingsPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ServerSettingsPage());
        }
    }
}
