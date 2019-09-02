using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppDevRepeatProject.Models
{
    public enum MenuItemType
    {
        //setting up the views for the menu
        HomeInfoPage,
        InfoPage
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
