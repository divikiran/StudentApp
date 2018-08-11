using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StudentApp.Views
{
    public partial class Pagetwo : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        public Pagetwo()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
