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

        // Sign out button
        async void SignOut(object sender, EventArgs e)
        {
            App.IsLoggedIn = false;
            App.LoggedIn = null;
            await Navigation.PushAsync(new Login());
        }

        // Change password button
        async void ChangePass(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangePassword());
        }
    }
}