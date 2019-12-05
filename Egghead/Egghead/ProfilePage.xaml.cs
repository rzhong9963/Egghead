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
    public partial class ProfilePage : ContentPage
    {
        //initialize page and set profile image
        public ProfilePage()
        {
            new Image { Source = "user.jpg" };
            InitializeComponent();
        }
        //set button to send user to editing page when clicked
        async void Edit_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfileEdit());
        }
    }
}