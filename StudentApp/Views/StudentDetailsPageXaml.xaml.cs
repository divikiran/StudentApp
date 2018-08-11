using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StudentApp.Views
{
    public partial class StudentDetailsPageXaml : ContentPage
    {
        public StudentDetailsPageXaml()
        {
            InitializeComponent();

            var outterStack = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Red,
                Spacing = 40,
                Padding = 50
            };

            var stack1 = new StackLayout();

            var label1 = new Label()
            {
                Text = "Label 1"
            };

            var image1 = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.britannica.com/668x448/98/1598-004-947CC5ED.jpg")),
            };


            stack1.Children.Add(label1);
            stack1.Children.Add(image1);


            outterStack.Children.Add(stack1);

            var label2 = new Label()
            {
                Text = "Label 2"
            };
            outterStack.Children.Add(label2);

            var label3 = new Label()
            {
                Text = "Label 3"
            };
            outterStack.Children.Add(label3);


            Content = outterStack;



            //if(Device.OS == TargetPlatform.iOS)
            //{
            //    Padding = new Thickness(0, 40, 0, 0);
            //}
            //else if (Device.OS == TargetPlatform.Android)
            //{
                
            //}

            //Padding = Device.OnPlatform(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android:new Thickness(0, 100, 0, 0)
            //);

        }
    }
}
