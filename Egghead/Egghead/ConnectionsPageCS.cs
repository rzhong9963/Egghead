using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Egghead
{
    public class ConnectionsPageCS : ContentPage
    {
        public ConnectionsPageCS()
        {
            Title = "Connections Page";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Contacts data goes here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}