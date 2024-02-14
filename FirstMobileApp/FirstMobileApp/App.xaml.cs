using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new Assignment();
            //MainPage = new Login();
            //MainPage = new Slider();
            //MainPage = new Assignment3();
            MainPage = new Assignment4();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
