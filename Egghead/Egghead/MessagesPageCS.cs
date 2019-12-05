
using Xamarin.Forms;

namespace Egghead
{
    public class MessagesPageCS : ContentPage
    {
        public MessagesPageCS()
        {
            Title = "Messages Page";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}