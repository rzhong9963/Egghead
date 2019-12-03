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
                    Name = "Michael Stevens", Text = "No Problem",
                },
                new Message()
                {
                    Name = "Dr. Mitchell Hogan", Text = "How are you holding up?"
                },
                new Message()
                {
                    Name = "Dr. Jonathan Miles", Text = "The meeting will be held, on Monday the 5th."
                },
                new Message()
                {
                    Name = "Andrew", Text = "i havent checked the hw yet"
                },
                new Message()
                {
                    Name = "Dr. Robert E. Speedwagon", Text = "Don't forget to sign up for the event tomorrow."
                }
                
            };
        }

       private async void OnItemSelected(Object sender,ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ChatPage());
        }


    }

}