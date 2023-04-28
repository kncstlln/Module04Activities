using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace PDC03Module04
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Activity2 : ContentPage
	{
		ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

		public ObservableCollection<Employee> Employees { get { return employees; } }
		public Activity2 ()
		{
			InitializeComponent ();

			employees.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "President" });
            employees.Add(new Employee { DisplayName = "Kane Castillano", Position = " Vice President" });
            employees.Add(new Employee { DisplayName = "Karylle Lopez", Position = "Secretary" });
            employees.Add(new Employee { DisplayName = "Aaron Echon", Position = "Treasurer" });
        }

		private void Add_Item(object sender, EventArgs e)
		{
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }

        private void Edit_Item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }

        private void Delete_Item(object sender, EventArgs e)
        {
			var menuItem = sender as MenuItem;	
			if (menuItem != null)
			{

			}
        }

    }
}