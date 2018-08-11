using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using StudentApp.Models;
using Xamarin.Forms;

namespace StudentApp.Views.MasterDetail
{
    public partial class SimpleMasterPage : ContentPage
    {
        public ObservableCollection<Customer> Customers
        {
            get;
            set;
        }

        public SimpleMasterPage()
        {
            InitializeComponent();

            Customers = new ObservableCollection<Customer>();

            var divi = new Customer
            {
                Name = "Divikiran Ravela",
                Address = "I am in Australia"
            };
            Customers.Add(divi);


            var anand = new Customer
            {
                Name = "Anand",
                Address = "I am in Hyderabad"
            };
            Customers.Add(anand);


            var prem = new Customer
            {
                Name = "Prem",
                Address = "I am in Secenderabad"
            };
            Customers.Add(prem);

            listName.ItemsSource = Customers;

        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var customer = e.SelectedItem as Customer;
            if (customer == null)
                throw new ArgumentNullException();
            
            await this.Navigation.PushAsync(new SimpleDetailPage(customer));

        }
    }
}
