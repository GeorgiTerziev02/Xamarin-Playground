using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableViewPage : ContentPage
    {
        public TableViewPage()
        {
            InitializeComponent();
        }

        private async void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new SignUpMethodsPage();
            page.SignUpMethods.ItemSelected += (source, args)=> 
            {
                signUpMethod.Text = args.SelectedItem.ToString();
                this.Navigation.PopAsync();
            };

            await this.Navigation.PushAsync(page);
        }
    }
}