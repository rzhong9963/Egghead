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

            var validUser = CheckCredentials(user);
            if (validUser)
            {
                
            }
            else
            {
                await DisplayAlert("Error", "Invalid Email/Password", "OK");
                email.Text = string.Empty;
                pass.Text = string.Empty;
            }
        }

        async void ForgotPassword(object sender, EventArgs e)
        {

        }

        async void SignUp(object sender, EventArgs e)
        {

        }
        
        bool CheckCredentials(User u)
        {
            return false; // False for now
        }
    }
}