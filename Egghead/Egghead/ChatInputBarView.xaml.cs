using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatInputBarView
    {
        public ChatInputBarView()
        {
            InitializeComponent();


        }

        void Handle_Completed(object sender, System.EventArgs e)
        {

        }
    }
}