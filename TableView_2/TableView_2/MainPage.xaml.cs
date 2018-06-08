using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


// Derives from TableView_1 to demonstrate using a Navigation technique
// to implement the Picker functionality (widely used since Picker is clumsy in iOS)
// Mosh: lecture 79
// Remember to change App with: MainPage = new NavigationPage(new MainPage());
// (switch & test handlers not here for simplification)

namespace TableView_2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        // navigate the user to the ContactsMethods page
        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new ContactMethodsPage();

            // ContactMethods = listView from ContactMethodsPage
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                // contactMethod = MainPage label name
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync(); // pop page from Navigation stack
            };
            // no need to await async calls because not doing anything after
            Navigation.PushAsync(page);
        }
    }
}
