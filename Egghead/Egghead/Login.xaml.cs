using Egghead.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        // Login button on login screen
        async void LoginButton(object sender, EventArgs e)
        {
            var user = new User
            {
                Email = email.Text,
                Password = pass.Text
            };

            // If the user got a temporary password, they are redirected to change it immediately
            // For some reason the last I tested it, it goes back to login screen :/
            if (pass.Text == TempPass.temp)
            {
                await Navigation.PushAsync(new ChangePassword());
            }
            var validUser = CheckCredentials(user);

            // Check to see if user is in database and sets their login status to true
            if (validUser)
            {
                App.IsLoggedIn = true;
                App.LoggedIn = await App.Database.GetUserAsync(user.Email, user.Password);
                App.UserEmail = user.Email;
                Navigation.InsertPageBefore(new MainPage(), this); // Change MainPage to whatever the actual Main Page (Connections) is named
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Error", "Invalid Email/Password", "OK");
                email.Text = string.Empty;
                pass.Text = string.Empty;
            }
        }

        // Go to forgot password page
        async void ForgotPass(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResetPassword());
        }

        // Go to sign up page
        async void SignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }

        // Check to see if user is in database
        bool CheckCredentials(User u)
        {
            var loggedin = App.Database.GetUserAsync(email.Text, pass.Text).Result;
            return loggedin != null;
        }
    }
}