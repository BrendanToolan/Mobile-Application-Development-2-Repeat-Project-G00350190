﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MobileAppDevRepeatProject.Models;
using MobileAppDevRepeatProject.ViewModels;

namespace MobileAppDevRepeatProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Name = "Item 1",
                Leaders = "This is an item description.",
                landmarks="This is a Landmark description"
                
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}