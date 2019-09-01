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

            var countryList = new List<string>();
            countryList.Add("America");
            countryList.Add("England");
            countryList.Add("France");
            countryList.Add("Italy");

            var picker = new Picker { Title = "Pick a Country", TextColor = Color.BlueViolet, FontSize=25};
            picker.ItemsSource = countryList;


        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }


    }

    
}