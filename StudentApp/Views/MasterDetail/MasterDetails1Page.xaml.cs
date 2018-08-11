using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using StudentApp.Models;
using Xamarin.Forms;

namespace StudentApp.Views.MasterDetail
{
    public partial class MasterDetails1Page : MasterDetailPage
    {
        public ObservableCollection<Customer> Customers
        {
            get;
            set;
        }

        public MasterDetails1Page()
        {
            InitializeComponent();

            Customers = new ObservableCollection<Customer>();
            this.IsPresented = true;
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

            listview.ItemsSource = Customers;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var customer = Customers.FirstOrDefault();
            this.Detail = new NavigationPage(new SimpleDetailPage(customer));
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var customer = e.SelectedItem as Customer;
            if (customer == null)
                throw new ArgumentNullException();

            this.Detail = new NavigationPage(new SimpleDetailPage(customer));
            this.IsPresented = false;
        }
    }
}
