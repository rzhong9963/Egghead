using Egghead.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        // SIgn up button
        async void SignUpButton(object sender, EventArgs e)
        {
            var u = new User();
            u.Email = email.Text;
            u.Password = pass.Text;
            // Get current users in system
            var users = await App.Database.GetUsersAsync();
            // If any field is empty
            if (email.Text == null|| pass.Text == null || passRep.Text == null)
            {
                await DisplayAlert("Error", "Fields cannot be empty", "OK");
            }
            // If all fields are filled and user is not already in system
            else if (ValidCredentials(u, users))
            {
                var firstPage = Navigation.NavigationStack.FirstOrDefault();
                if (firstPage != null)
                {
                    // Save the user into the local database
                    await App.Database.SaveUserAsync(u);
                    App.IsLoggedIn = true;
                    App.LoggedIn = u;
                    //Navigation.InsertPageBefore(new ProfilePage(), Navigation.NavigationStack.First()); // Profile creation page or whatever
                    Navigation.InsertPageBefore(new MainPage(), Navigation.NavigationStack.First()); // Profile creation page or whatever

                    await Navigation.PopToRootAsync();
                }
            }
        }

       // Checks to make sure all fields are valid and have the correct info
        bool ValidCredentials(User u, List<User> users)
        {
            bool valid = false;
            if (u.Email.Length <= 0)
                ErrorMsg.Text = "Please enter an email address";
            else if (users.Find(x => x.Email.ToLower() == u.Email.ToLower()) != null)
                ErrorMsg.Text = "Email already in use";
            else if (u.Email.Substring(Math.Max(0, u.Email.Length - 4)) != ".edu")
                ErrorMsg.Text = "Email must be a valid .edu address";
            else if (!u.Email.Contains("@"))
                ErrorMsg.Text = "Invalid Email address";
            else if (u.Password.Length < 8)
                ErrorMsg.Text = "Password must be at least 8 characters";
            else if (u.Password != passRep.Text)
                ErrorMsg.Text = "Passwords do not match";
            else
                valid = true;
            return valid;
        }
    }
}