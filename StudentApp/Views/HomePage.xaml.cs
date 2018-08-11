using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StudentApp.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new Pagetwo());
        }
    }
}
