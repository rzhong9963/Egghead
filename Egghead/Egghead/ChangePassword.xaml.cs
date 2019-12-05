using System;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePassword : ContentPage
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        // Change Password Button
        public async void ChangePass(object sender, EventArgs e)
        {
            // Get user info from login email
            var u = await App.Database.GetUserAsync(App.UserEmail);
            
            // Check to see if the temporary password from forgotten password is their current one
            if (u != null && u.Password == TempPass.temp)
            {
                u.Password = pass.Text;
                if(Valid()) {
                    await App.Database.SaveUserAsync(u);
                    await DisplayAlert("Success", "Password Changed", "OK");
                    Change(sender, e);
                }
                else
                {
                    await DisplayAlert("Error", "An Unknown Error Occured", "OK");
                }
            }
            else if (u != null)
            {
                u.Password = pass.Text;
                if (Valid())
                {
                    await App.Database.SaveUserAsync(u);
                    await DisplayAlert("Success", "Password Changed", "OK");
                    Change(sender, e);
                }
                else
                {
                    await DisplayAlert("Error", "An Unknown Error Occured", "OK");
                }
            }
        }

        // Change the user's password
        async void Change(object sender, EventArgs e)
        {
            var u = await App.Database.GetUserAsync(App.UserEmail);
            if(TempPass.temp != u.Password)
            {
                await Navigation.PopAsync();
            }
            else
            {
                App.IsLoggedIn = true;
                App.LoggedIn = u;
                await Navigation.PopToRootAsync();
            }
        }

        // Determines if the passwords meet the minimum requirements
        public bool Valid()
        {
            bool v = false;
            if (pass.Text.Length < 8)
                ErrorMsg.Text = "Password must be at least 8 characters";
            else if (pass.Text != passRep.Text)
                ErrorMsg.Text = "Passwords do not match";
            else
                v = true;
            return v;
        }
    }
}