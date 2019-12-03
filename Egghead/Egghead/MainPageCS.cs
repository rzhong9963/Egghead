﻿using System;

using Xamarin.Forms;

namespace Egghead
{
    public class MainPageCS : MasterDetailPage
    {
        MasterPageCS masterPage;

        public MainPageCS()
        {
            
            masterPage = new MasterPageCS();
            Master = masterPage;
            Detail = new NavigationPage(new ConnectionsPageCS());

            Detail = new NavigationPage(new MessagesPageCS());

            Detail = new NavigationPage(new SettingsPageCS());

            masterPage.ListView.ItemSelected += OnItemSelected;


            if (Device.RuntimePlatform == Device.UWP)
            {
                MasterBehavior = MasterBehavior.Popover;
            }
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}