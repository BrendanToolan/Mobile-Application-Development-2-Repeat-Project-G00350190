using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppDevRepeatProject.Models
{
    public enum MenuItemType
    {
        Home,
        About,
        Contact
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
