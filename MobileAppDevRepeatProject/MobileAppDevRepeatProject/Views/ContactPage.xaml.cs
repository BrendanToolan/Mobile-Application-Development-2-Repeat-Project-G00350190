using MobileAppDevRepeatProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppDevRepeatProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        ContactModel viewModel;

        public ContactPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ContactModel();
        }
    }
        
}