using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PasswordPage : ContentPage
    {
        public PasswordPage()
        {
            InitializeComponent();
            Pass.Text = TempPass.temp;
        }

        async void Cont(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PopAsync();
        }
    }
}