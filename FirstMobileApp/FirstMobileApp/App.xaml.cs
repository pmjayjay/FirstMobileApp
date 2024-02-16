using FirstMobileApp.Views;
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
            //MainPage = new Assignment4();
            //MainPage = new Calculator();
            //MainPage = new Cal();
            //MainPage = new GridExample();
            //MainPage = new GridExample1();
            //MainPage = new NavigationPage(new HomePage());
            //MainPage = new TabbedPageDemo();
            //MainPage = new CarouselPageDemo();
            //MainPage = new NavigationPage(new TootBarDemo());
            MainPage  = new NavigationPage(new MasterListPage());
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
