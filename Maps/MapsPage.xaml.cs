﻿using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Maps
{
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();

			BuildMap();
        }

        public void BuildMap()
        {
			var map = new Map(
			MapSpan.FromCenterAndRadius(
					new Position(37, -122), Distance.FromMiles(0.3)))
			{
				IsShowingUser = true,
				HeightRequest = 100,
				WidthRequest = 960,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			var stack = new StackLayout { Spacing = 0 };
			stack.Children.Add(map);
			Content = stack;
        }
    }
}
