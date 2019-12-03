using Egghead.Data;
using Egghead.Models;
using System;
using System.IO;
using Xamarin.Forms;

namespace Egghead
{
    public partial class App : Application
    {
        public static string Name = "Murphy";
        public static bool IsLoggedIn
        {
            get;
            set;
        }

        public static User LoggedIn
        {
            get;
            set;
        }

        public static string UserEmail
        {
            get;
            set;
        }

        static UserDB db;

        public static UserDB Database
        {
            get
            {
                if (db == null)
                {
                    db = new UserDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Users.db3"));
                }
                return db;
            }
        }

        public App()
        {
            //InitializeComponent();

            //MainPage = new MainPage();
            if (!IsLoggedIn)
            {
                var login = new NavigationPage(new Login());
               
                MainPage = login;
            }
            else
            {
                MainPage = new NavigationPage(new MainPage()); // This needs to be changed to whatever the Main Page is named
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
