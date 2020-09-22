using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        public ListPage()
        {
            InitializeComponent();

            _contacts = new ObservableCollection<Contact> 
            {
                   new Contact{Name="AAA", ImageUrl="https://onlinejpgtools.com/images/examples-onlinejpgtools/coffee-resized.jpg", Status="AAA"},
                   new Contact{Name="ABC", ImageUrl="https://onlinejpgtools.com/images/examples-onlinejpgtools/coffee-resized.jpg"},   
                   new Contact{Name="BBB", ImageUrl="https://onlinejpgtools.com/images/examples-onlinejpgtools/coffee-resized.jpg"}
                //new Contact{Name="AAA", ImageUrl="https://onlinejpgtools.com/images/examples-onlinejpgtools/coffee-resized.jpg"},
            };

            listView.ItemsSource = _contacts;
        }

        private void CallClicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private void DeleteClicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }
    }
}