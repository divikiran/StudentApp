using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using StudentApp.Models;
using Xamarin.Forms;

namespace StudentApp.Views
{
    public partial class ListviewPage : ContentPage
    {
        public int Number
        {
            get;
            set;
        }
        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            
            Customers.Add(new Customer()
            {
                Name = Number++ + " Customer",
                Address = "Moon",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Australia-climate-map_MJC01.png/600px-Australia-climate-map_MJC01.png",
                Color = Color.Aqua,

            });

            //listview.IsRefreshing = false;
            listview.EndRefresh();
        }

        
        public ObservableCollection<Customer> Customers
        {
            get;
            set;
        }

        public ListviewPage()
        {
            InitializeComponent();

            NotfoundLabel.IsVisible = false;

            Customers = new ObservableCollection<Customer>();
            Customers.Add(new Customer()
            {
                Name = "Divikiran",
                Address = "Australia",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Australia-climate-map_MJC01.png/600px-Australia-climate-map_MJC01.png",
                Color =Color.Accent,
                    
            });

            Customers.Add(new Customer()
            {
                Name = "Prem",
                Address = "Vanastilipuram",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Australia-climate-map_MJC01.png/600px-Australia-climate-map_MJC01.png",
                Color = Color.AliceBlue,
            });

            Customers.Add(new Customer()
            {
                Name = "Anand",
                Address = "OU campus",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Australia-climate-map_MJC01.png/600px-Australia-climate-map_MJC01.png",
                Color = Color.Aqua,
            });


            listview.ItemsSource = Customers;
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Customer;

            var customer = Customers.FirstOrDefault(w => w.Name == contact.Name );
            Customers.Remove(customer);

        }

        void Call_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var name = menuItem.CommandParameter as string;

            DisplayAlert("Call", "Are you sure, you want to call "+  name +"?", "OK");
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            //   FilterCustomers(sender);
            NotfoundLabel.IsVisible = false;
            var searchControl = sender as SearchBar;

            if (searchControl == null)
                return;

            var searchText = searchControl.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                listview.ItemsSource = Customers;
            }

        }

        private void FilterCustomers(object sender)
        {
            var searchControl = sender as SearchBar;

            if (searchControl == null)
                return;

            var searchText = searchControl.Text.ToLower();


            var remainingCustomers = new List<Customer>();
            foreach (var c in Customers)
            {
                if (c.Name.ToLower().Contains(searchText))
                {
                    remainingCustomers.Add(c);
                }
            }

            if(remainingCustomers.Count == 0)
            {
                NotfoundLabel.IsVisible = true;
            }
            else
            {
                NotfoundLabel.IsVisible = false;
            }


            listview.ItemsSource = remainingCustomers;
        }

        void Handle_SearchButtonPressed(object sender, System.EventArgs e)
        {
            FilterCustomers(sender);
        }
    }
}
