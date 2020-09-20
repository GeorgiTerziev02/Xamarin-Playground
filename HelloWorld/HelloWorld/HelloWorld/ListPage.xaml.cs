using HelloWorld.Models;
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
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            this.listView.ItemsSource = new List<ContactGroup> 
            {
                new ContactGroup("A", "A")
                {
                   new Contact{Name="AAA", ImageUrl="https://onlinejpgtools.com/images/examples-onlinejpgtools/coffee-resized.jpg", Status="AAA"},
                   new Contact{Name="ABC", ImageUrl="https://onlinejpgtools.com/images/examples-onlinejpgtools/coffee-resized.jpg"}
                },
                new ContactGroup("B", "B")
                {
                   new Contact{Name="BBB", ImageUrl="https://onlinejpgtools.com/images/examples-onlinejpgtools/coffee-resized.jpg"}
                }
                //new Contact{Name="AAA", ImageUrl="https://onlinejpgtools.com/images/examples-onlinejpgtools/coffee-resized.jpg"},
            };
        }
    }
}