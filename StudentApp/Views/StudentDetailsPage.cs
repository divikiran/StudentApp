using System;

using Xamarin.Forms;

namespace StudentApp.Views
{
    public class StudentDetailsPage : ContentPage
    {
        public StudentDetailsPage()
        {
            Title = "Student Detail";

            var studentNameLabel = new Label
            {
                Text = "Student Name",

            };

            var studentNameEntry = new Entry
            {
                Text = "Rajiv"
            };


            Content = new StackLayout{
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    studentNameLabel,
                    studentNameEntry,

                }
            };



            //Content = new StackLayout
            //{
            //    Children = {
            //        new Label { Text = "Hello ContentPage" }
            //    }
            //};
        }
    }
}

