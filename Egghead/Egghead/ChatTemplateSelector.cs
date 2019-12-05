
using Xamarin.Forms;

namespace Egghead
{
    class ChatTemplateSelector : DataTemplateSelector
    {   //set datatemplate
        DataTemplate incomingDataTemplate;
        DataTemplate outgoingDataTemplate;

        public ChatTemplateSelector()
        {   //set templates
            this.incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
            this.outgoingDataTemplate = new DataTemplate(typeof(OutgoingViewCell));
        }
        //check to see if the chat is different from current user
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as Message;
            if (messageVm == null)
                return null;


            return (messageVm.Name == App.Name) ? outgoingDataTemplate : incomingDataTemplate;
        }

    }
}
