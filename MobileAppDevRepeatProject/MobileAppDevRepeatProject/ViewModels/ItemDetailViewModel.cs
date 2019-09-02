using System;

using MobileAppDevRepeatProject.Models;

namespace MobileAppDevRepeatProject.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Name;
            Item = item;
        }
    }
}
