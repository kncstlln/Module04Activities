using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03Module04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity05 : ContentPage
    {

        List<Contacts> contacts;
        public Activity05()
        {
            InitializeComponent();
            SetupData();
            ListView.ItemsSource = contacts;
            
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(ListView.SelectedItem != null)
            {
                var detailpage = new DetailedPage();
                detailpage.BindingContext = e.SelectedItem as Contacts;
                ListView.SelectedItem = null;
                await Navigation.PushAsync(detailpage);
            }


        }
           

        void SetupData()
        {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
                {
                    Name = "Kane Erryl Castillano",
                    Age = 20,
                    Occupation = "Information Technology Specialist",
                    Country= "Philippines"
                });
            contacts.Add(new Contacts
            {
                Name = "Karylle Lopez",
                Age = 20,
                Occupation = "Front End Developer",
                Country = "South Korea"
            });
            contacts.Add(new Contacts
            {
                Name = "Arnold Nicholas Lim",
                Age = 21,
                Occupation = "Volleyball Player",
                Country = "Brazil"
            });
            contacts.Add(new Contacts
            {
                Name = "Aaron Echon",
                Age = 23,
                Occupation = "F1 Driver",
                Country = "Germany"
            });
            contacts.Add(new Contacts
            {
                Name = "Micoh Yabut",
                Age = 22,
                Occupation = "Police",
                Country = "USA"
            });
        }
    }
}