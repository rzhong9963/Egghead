using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ImageCircle.Forms.Plugin.Abstractions;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            CircleImage ditto = new CircleImage
            {
                BorderColor = Color.White,
                BorderThickness = 3,
                HeightRequest = 150,
                WidthRequest = 150,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                Source = "ditto.jpg"
            };
            InitializeComponent();
           // var profilePic = new {Source = "ditto.jpg"};
            
        }
    }
}
