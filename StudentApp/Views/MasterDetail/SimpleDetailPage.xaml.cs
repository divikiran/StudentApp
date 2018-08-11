using System;
using System.Collections.Generic;
using StudentApp.Models;
using Xamarin.Forms;

namespace StudentApp.Views.MasterDetail
{
    public partial class SimpleDetailPage : ContentPage
    {
        public SimpleDetailPage(Customer customer)
        {
            InitializeComponent();
            BindingContext = customer;
        }
    }
}
