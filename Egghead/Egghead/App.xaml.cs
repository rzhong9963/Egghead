using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    public partial class App : Application
    {

        public static bool IsLoggedIn
        {
            get;
            set;
        }

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            if (!IsLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new Egghead.MainPage());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
