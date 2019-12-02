
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnectionsPage : ContentPage
    {
        public ConnectionsPage()
        {
            InitializeComponent();

            AbsoluteLayout.SetLayoutBounds(pic_box, new Rectangle(0, 0, .3, pic_box.Width));
        }
    }
}