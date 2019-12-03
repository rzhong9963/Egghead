﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egghead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            new Image { Source = "ditto.jpg" };
            void Edit_Button_Clicked(object sender, EventArgs e)
            {
                Navigation.PushAsync(new ProfileEdit());
            }
            InitializeComponent();
        }
    }
}