namespace HelloWorld
{ 
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            this.slider.Value = 0.5;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = string.Format("Value is {0:f2}", e.NewValue);
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.DisplayAlert("Hello title", "Hello! How are you!", "Fine, thank you!", "Not fine...");
        }
    }
}