using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StudentApp.Views.PopUps
{
    public partial class PopupPage : ContentPage
    {
        public PopupPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.White;
        }

        async void Handle_Clicked(object sender, System.EventArgs e)

        {
            this.BackgroundColor = Color.White;
            var fNumber = Convert.ToInt32(firstNumber.Text);
            var sNumber = Convert.ToInt32(secondNumnber.Text);

            var total = fNumber + sNumber;
            if(total > 10)
            {
                await this.DisplayAlert("Title", "Total result is " + total, "OK");    
            }

            if(total > 20)
            {
                var userSaidOk = await this.DisplayAlert("Turn RED", "Do you want to change background color to RED", "OK", "Cancel");    
                if(userSaidOk)
                {
                    this.BackgroundColor = Color.Red;
                }
            }

        }
    }
}
