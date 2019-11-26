using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Name = "Julia", Text = "Hi! :)"
                },
                new Message()
                {
                    Name = "Rob", Text = "Geaux Tigers!"
                }
            };
          
        }
        void TextCell_Tapped(object sender,Xamarin.Forms.ItemTappedEventArgs e)
        {
            throw new NotImplementedException();
        }
      
    }
   
}