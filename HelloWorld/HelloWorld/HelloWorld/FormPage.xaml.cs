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
    public partial class FormPage : ContentPage
    {
        private IList<SignUpMethod> _signUpMethods;

        private IList<SignUpMethod> GetSignUpMethods()
        {
            return new List<SignUpMethod>()
            {
                new SignUpMethod{ Id = 1, Name = "Email"},
                new SignUpMethod{ Id = 2, Name = "Facebook"},
            };
        }

        public FormPage()
        {
            InitializeComponent();

            this._signUpMethods = this.GetSignUpMethods();
            foreach (var method in _signUpMethods)
            {
                signUpMethods.Items.Add(method.Name);
            }
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            label.IsVisible = e.Value;
        }

        private void Password_Completed(object sender, EventArgs e)
        {
            passwordLabel.Text = "Completed";
        }

        // async void is a bad practice
        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = signUpMethods.Items[signUpMethods.SelectedIndex];
            var signUpMethod = this._signUpMethods.SingleOrDefault(s => s.Name == name);

            await DisplayAlert("Selected", $"You selected {name}", "Ok");
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new TableViewPage());
        }
    }

    public class SignUpMethod
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}