using MobileAppDevRepeatProject.Models;
using MobileAppDevRepeatProject.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileAppDevRepeatProject.ViewModels
{
    public class HomeInfoViewModel : BaseViewModel
    {

        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public HomeInfoViewModel()
        {
            
            Title = "HomeInfoPage";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });

           

        }

        private Task<Func<object, bool>> ExecuteLoadItemsCommand()
        {
            throw new NotImplementedException();
        }
    }
}
