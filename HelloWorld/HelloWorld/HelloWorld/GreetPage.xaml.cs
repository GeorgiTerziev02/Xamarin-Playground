namespace HelloWorld
{
    using System.Collections.Generic;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        protected List<string> texts = new List<string>()
        {
            "Hello",
            "How are you",
            "I am good",
            "aaaa",
            "Start over again"
        };

        protected int index = -1;

        public GreetPage()
        {
            InitializeComponent();

            this.slider.Value = 0.5;
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.DisplayAlert("Hello title", "Hello! How are you!", "Fine, thank you!", "Not fine...");
        }

        private void NextText(object sender, System.EventArgs e)
        {
            index++;
            if(index >= this.texts.Count)
            {
                index = 0;
            }

            this.label.Text = this.texts[index];
        }

        private void ChangeFont(object sender, ValueChangedEventArgs e)
        {
            this.label.FontSize = e.NewValue * 25;
        }
    }
}