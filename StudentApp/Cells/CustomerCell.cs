using System;
using Xamarin.Forms;

namespace StudentApp.Cells
{
    public class CustomerCell : ViewCell
    {
        public CustomerCell()
        {
            var name = new Label();
            name.SetBinding(Label.TextProperty, "Name");

            var address = new Label();
            address.SetBinding(Label.TextProperty, "Address");

            var stack = new StackLayout();
            //stack.Orientation = StackOrientation.Horizontal;
            stack.Children.Add(name);
            stack.Children.Add(address);

            View = stack;

        }
    }
}
