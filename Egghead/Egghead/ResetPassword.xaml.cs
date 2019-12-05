using System;
using System.Linq;
using System.Security.Cryptography;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResetPassword : ContentPage
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        // Reset password button after a valid email is given redirecting user to their temporary password
        async void ResPas(object sender, EventArgs e)
        {
            var u = App.Database.GetUserAsync(Email.Text);

            if(u.Result == null)
            {               
                Err.IsVisible = true;
            }
            else
            {
                Err.IsVisible = false;
                TempPass.temp = temp();
                TempPass.user = u.Result.Email;
                u.Result.Password = TempPass.temp;
                await App.Database.SaveUserAsync(u.Result);
                await Navigation.PushAsync(new PasswordPage());
            }

        }
        // Securely generate a completely random password
        const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        static string temp(int length = 15)
        {
            string s = "";
            using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
            {
                while (s.Length != length)
                {
                    byte[] oneByte = new byte[1];
                    provider.GetBytes(oneByte);
                    char character = (char)oneByte[0];
                    if (valid.Contains(character))
                    {
                        s += character;
                    }
                }
            }
            return s;
        }
    }
}