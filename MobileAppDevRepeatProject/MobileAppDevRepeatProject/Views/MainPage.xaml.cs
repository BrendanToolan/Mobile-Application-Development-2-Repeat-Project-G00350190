﻿using MobileAppDevRepeatProject.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppDevRepeatProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
            //set up the first place we will see
            MenuPages1.Add((int)MenuItemType.InfoPage, (NavigationPage)Detail);
        }

        public Dictionary<int, NavigationPage> MenuPages1 { get; set; } = new Dictionary<int, NavigationPage>();

        public async Task NavigateFromMenu(int id)
        {
            //if statement to switch between pages
            if (!MenuPages1.ContainsKey(id))
            {
                switch (id)
                {

                    case (int)MenuItemType.HomeInfoPage:
                        MenuPages1.Add(id, new NavigationPage(new HomeInfoPage()));
                        break;
                    case (int)MenuItemType.InfoPage:
                        MenuPages1.Add(id, new NavigationPage(new ItemsPage()));
                        break;

                    
                }
            }

            var newPage = MenuPages1[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}