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
                    Name = "Dr.Mitchell ", Text = "Good to know, see you then!", 
                },
                new Message()
                {
                    Name = "Andrew", Text = "Geaux Tigers!"
                },
                new Message()
                {
                    Name = "Professor", Text = "Geaux Tigers!"
                }
            };

        }

       private async void OnItemSelected(Object sender,ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ChatPage());
        }


    }

}