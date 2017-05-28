using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Maps
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void btnMap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapsPage());
             // GetPage();
        }

        public static Page GetPage()
        {
            return new NavigationPage(new MapsPage());
        }
    }
}
