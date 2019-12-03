
using Xamarin.Forms;

namespace Egghead
{
    public class SettingsPageCS : ContentPage
    {
        public SettingsPageCS()
        {
            Title = "Connections Page";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Under development!",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}