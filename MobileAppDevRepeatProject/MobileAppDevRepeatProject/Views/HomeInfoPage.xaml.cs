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
    public partial class HomeInfoPage : ContentPage
    {
        HomeInfoViewModel viewModel;
        

        public HomeInfoPage()
        {
            
            InitializeComponent();
            //connectd this view to the view model
            BindingContext = viewModel = new HomeInfoViewModel();

            //picker var and also populated
            var countryList = new List<string>();
            countryList.Add("America");
            countryList.Add("England");
            countryList.Add("France");
            countryList.Add("Italy");
            countryList.Add("Ireland");
            countryList.Add("Germany");
            countryList.Add("Netherlands");

            //variable that will display "Pick a Country" on the picker
            var picker = new Picker { Title = "Pick a Country", TextColor = Color.BlueViolet, FontSize=25};
            picker.ItemsSource = countryList;

            //Displays the name
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

      /*  private string List()
        {
            throw new NotImplementedException();
        }*/

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
            //Various If Statements that will display information based on what was picked from the picker

            if(index == 0)
            {
                
                countryLabel.Text = "Country Name - America";
                countryLabelLeader.Text = "Leader - President Donald J Trump";
                NotableLandmarksLabel.Text = "Known Landmark - The White House";
                
                
            }
            if (index == 1)
            {
                countryLabel.Text = "Country Name England";
                countryLabelLeader.Text = "Leader - Prime Miniser Boris Johnson";
                NotableLandmarksLabel.Text = "Known Landmark - Big Ben";
            }
            if (index == 2)
            {
                countryLabel.Text = "Country Name - France";
                countryLabelLeader.Text = "Leader - President Emmanuel Macron";
                NotableLandmarksLabel.Text = "Known Landmark - The Effiel Tower";
            }
            if (index == 3)
            {
                countryLabel.Text = "Country Name - Italy";
                countryLabelLeader.Text = "Sergio Mattarella";
                NotableLandmarksLabel.Text = "Known Landmark - The Leaning Tower";
            }
            if (index == 4)
            {
                countryLabel.Text = "Country Name - Ireland";
                countryLabelLeader.Text = "Leader - Taoisearch Leo Varadkar";
                NotableLandmarksLabel.Text = "Known Landmark - Blarney Castle";

            }
            if (index == 5)
            {
                countryLabel.Text = "Country Name - Germany";
                countryLabelLeader.Text = "Leader - Chancellor Angela Merkel";
                NotableLandmarksLabel.Text = "Known Landmark - Cologne Catherdal";

            }
            if(index == 6)
            {
                countryLabel.Text = "Country Name - Netherlands";
                countryLabelLeader.Text = "Leader - Prime Minister Mark Rutte";
                NotableLandmarksLabel.Text = "Van Gogh Museum";
            }
        }
    }

    
}