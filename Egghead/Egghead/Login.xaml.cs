using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Egghead.Models;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void LoginButton(object sender, EventArgs e)
        {
            var user = new User
            {
                Email = email.Text,
                Password = pass.Text
            };

            if(pass.Text == TempPass.temp)
            {
                await Navigation.PushAsync(new ChangePassword());
            }
            var validUser = CheckCredentials(user);
            if (validUser)
            {
                App.IsLoggedIn = true;
                App.LoggedIn = await App.Database.GetUserAsync(user.Email, user.Password);
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

        async void ForgotPass(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResetPassword());
        }

        async void SignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }
        
        bool CheckCredentials(User u)
        {
            var loggedin = App.Database.GetUserAsync(email.Text, pass.Text).Result;
            return loggedin != null;
        }
    }
}