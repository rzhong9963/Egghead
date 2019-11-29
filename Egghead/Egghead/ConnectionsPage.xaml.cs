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
    public partial class ConnectionsPage : ContentPage
    {
        public ConnectionsPage()
        {
            InitializeComponent();
        }

        public async void ChangePass(object sender, EventArgs e)
        {
            if (Valid())
            {
                var u = await App.Database.GetUserAsync(TempPass.user);
                if(u != null)
                {
                    u.Password = pass.Text;
                    await App.Database.SaveUserAsync(u);
                    App.IsLoggedIn = true;
                    App.LoggedIn = u;
                    Navigation.InsertPageBefore(new MainPage(), Navigation.NavigationStack.First());
                    await Navigation.PopToRootAsync(); // Change MainPage to whatever the actual Main Page (Connections) is named
                }
                else
                {
                    ErrorMsg.Text = "An Unknown Error Occurred";
                }
            }
        }

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