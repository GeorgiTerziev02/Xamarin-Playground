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
    public partial class SignUpMethodsPage : ContentPage
    {
        public SignUpMethodsPage()
        {
            InitializeComponent();

            this.listView.ItemsSource = new List<string>
            {
                "None",
                "Email",
                "Facebook"
            };
        }

        public ListView SignUpMethods { get { return this.listView; } }
    }
}