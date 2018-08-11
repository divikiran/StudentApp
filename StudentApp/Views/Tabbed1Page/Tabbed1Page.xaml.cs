using System;
using System.Collections.Generic;
using StudentApp.Views;
using Xamarin.Forms;

namespace StudentApp
{
    public partial class Tabbed1Page : TabbedPage
    {
        public Tabbed1Page()
        {
            InitializeComponent();

            this.Children.Add(new GridPage(){ Icon="grid.png"});
            this.Children.Add(new ImagesPage(){ Icon = "image.png" });
            NavigationPage page = new NavigationPage(new HomePage()){ Icon = "home.png"};
            this.Children.Add(page);
            //this.Children.Add(new HomePage());
            this.Children.Add(new ListviewPage(){Icon="contact.png"});
            this.Children.Add(new StudentDetailsPage(){Icon="detail.png"});
        }
    }
}