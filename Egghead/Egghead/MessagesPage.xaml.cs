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
                    Name = "Julia", Text = "Hi! :)", 
                },
                new Message()
                {
                    Name = "Rob", Text = "Geaux Tigers!"
                }
                
            };

        }

       private async void OnItemSelected(Object sender,ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ChatPage());
        }


    }

}