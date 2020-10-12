using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // async void is a bad practice
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage());
        }

        // async void is a bad practice
        private async void ModalPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GreetPage());
        }

        // async void is a bad practice
        private async void TabbedPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabsPage());
        }

        // async void is a bad practice
        private async void FormPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormPage());
        }

        // async void is a bad practice
        private async void ApiPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RestApiPage());
        }

        // async void is a bad practice
        private async void DisplayActionSheet(object sender, EventArgs e)
        {
            // null instead of delete
            var response = await DisplayActionSheet("Title", "Cancel","DELETE", "Option 1", "Option 2", "Option 3" );
            await DisplayAlert("You chose", response, "Ok");
        }
    }
}
