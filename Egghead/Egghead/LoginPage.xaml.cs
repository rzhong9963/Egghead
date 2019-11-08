using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnSignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        async void OnLoginClicked(object sender, EventArgs e)
        {
            
            // Do Stuff
        }

        bool CheckCredentials(User user)
        {
            return false;
        }
    }
}