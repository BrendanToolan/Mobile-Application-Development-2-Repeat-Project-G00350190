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
            countryList.Add("Ireland");
            countryList.Add("Germany");
            countryList.Add("Netherlands");

            var picker = new Picker { Title = "Pick a Country", TextColor = Color.BlueViolet, FontSize=25};
            picker.ItemsSource = countryList;

            var countryNameLabel = new Label();
            countryNameLabel.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: picker));

            var selectedIndex = 0;

            void onPickerSelectedIndexChanged(object sender, EventArgs e)
            {
                var picker2 = (Picker)sender;
                int selectedItem = picker.SelectedIndex;

                //if statement
                if (selectedIndex != -1)
                {
                    countryNameLabel.Text = NewMethod(picker, selectedItem);
                }

            }

        }

        private string List()
        {
            throw new NotImplementedException();
        }

        private static string NewMethod(Picker picker, int selectedItem)
        {
            return (string)picker.ItemsSource[selectedItem];
        }


        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = picker.SelectedIndex;
            if(index == 0)
            {
                
                countryLabel.Text = "Country Name - America";
                countryLabelLeader.Text = "Leader - President Donald J Trump";
                
            }
            if (index == 1)
            {
                countryLabel.Text = "Country Name England";
                countryLabelLeader.Text = "Leader - Prime Miniser Boris Johnson";
            }
            if (index == 2)
            {
                countryLabel.Text = "Country Name - France";
                countryLabelLeader.Text = "Leader - President Emmanuel Macron";
            }
        }
    }

    
}