using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Security.Cryptography;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResetPassword : ContentPage
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        async void ResPas(object sender, EventArgs e)
        {
            var u = App.Database.GetUserAsync(Email.Text);
            if(u.Result == null)
            {
                Msg.Text = "No account with the email exists";
            }
            else if (u.Result.Email == Email.Text)
            {
                TempPass.temp = temp();
                TempPass.user = u.Result.Email;
                u.Result.Password = TempPass.temp;
                await App.Database.SaveUserAsync(u.Result);
                await Navigation.PushAsync(new PasswordPage());
            }
        }
        // Securely generate a completely random password
        const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        static string temp(int length=15)
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