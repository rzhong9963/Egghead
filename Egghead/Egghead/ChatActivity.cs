using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Egghead
{
    class ChatActivity : INotifyPropertyChanged
    {   //set variables and get setters
        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();
        public string TextToSend { get; set; }
        public ICommand OnSendCommand { get; set; }
        public ChatActivity()
        {  //add new messages
            Messages.Add(new Message() { Text = "Hi" });
            Messages.Add(new Message() { Text = "How are you?" });

            OnSendCommand = new Command(() =>
            {   //when send is tapped send message
                if (!string.IsNullOrEmpty(TextToSend))
                {
                    Messages.Add(new Message() { Text = TextToSend, Name = App.Name });
                    TextToSend = string.Empty;
                }

            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
