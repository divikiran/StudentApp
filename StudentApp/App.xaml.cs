using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StudentApp.Views;
using StudentApp.Views.Tabbed1Page;
using StudentApp.Views.MasterDetail;
using StudentApp.Views.PopUps;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace StudentApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Tabbed1Page();
            //MainPage = new Tabbed1Page();
            //MainPage = new NavigationHomePage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
