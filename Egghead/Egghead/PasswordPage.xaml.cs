using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PasswordPage : ContentPage
    {
        // All this does is print their password in plain text
        // Yes it's not secure, but it gets the job done
        public PasswordPage()
        {
            InitializeComponent();
            Pass.Text = TempPass.temp;
        }

        // Go to login page once continue button is clicked
        async void Cont(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PopAsync();
        }
    }
}