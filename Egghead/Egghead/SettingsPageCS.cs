using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                    new Label { Text = "Welcome to Xamarin.Forms!",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}