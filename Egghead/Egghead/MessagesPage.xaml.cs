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
                    Name = "Dr. Robert E. Speedwagon", Text = "Don't forget to sign up for the event tomorrow."
                },
                new Message()
                {
                    Name = "Dr. Jonathan Miles", Text = "The meeting will be held, on Monday the 5th."
                },
                new Message()
                {
                    Name = "Dr. Jonathan Miles", Text = "The meeting will be held, on Monday the 5th."
                },
                new Message()
                {
                    Name = "Dr. Mitchell Hogan", Text = "How are you holding up?"
                }
        }

       private async void OnItemSelected(Object sender,ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ChatPage());
        }


    }

}