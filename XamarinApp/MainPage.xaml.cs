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
        }

        int t = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            t++;
            lbl1.Text = t.ToString();
        }
    }
}
