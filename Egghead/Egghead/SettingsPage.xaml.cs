using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        async void SignOut(object sender, EventArgs e)
        {
            App.IsLoggedIn = false;
            App.LoggedIn = null;
            await Navigation.PushAsync(new Login());
        }
    }
}