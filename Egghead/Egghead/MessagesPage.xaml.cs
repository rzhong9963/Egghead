using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessagesPage : ContentPage
    {
        public MessagesPage()
        {
            InitializeComponent();
            lst.ItemsSource = new List<Message>()
            {
                new Message()
                {
                    Name = "Dr. Mitchell Hogan ", Text = "How are you holding up?", 
                },
                new Message()
                {
                    Name = "Dr. Jonathan Miles", Text = "The meeting will be held, on Monday the 5th."
                },
                new Message()
                {
                    Name = "Andrew.", Text = "I've got a bunch of other things to do this week tho"
                },
                new Message()
                {
                    Name = "", Text = ""
                },
                new Message()
                {
                    Name = "Dr. Robert E. Speedwagon", Text = ""
                }
            };

        }

       private async void OnItemSelected(Object sender,ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ChatPage());
        }


    }

}