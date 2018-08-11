using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StudentApp.Models;
using Xamarin.Forms;

namespace StudentApp.Views.MasterDetail
{
    public partial class ActualMasterDetailPage : MasterDetailPage
    {
        public ObservableCollection<Customer> Customers
        {
            get;
            set;
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var customer = e.SelectedItem as Customer;
            if (customer == null)
                throw new ArgumentNullException();
            
            this.Detail = new NavigationPage(new SimpleDetailPage(customer));
            this.IsPresented = false; 

        }

        public ActualMasterDetailPage()
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
    }
}
