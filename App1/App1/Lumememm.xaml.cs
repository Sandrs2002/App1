using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace App1
{	
	public partial class Lumememm : ContentPage
	{
		BoxView bucket, snow1, snow2;
        Slider sld;
        public Lumememm ()
		{
            BackgroundImageSource = "snowmount.jpg";
            bucket = new BoxView
			{
                BackgroundColor = Color.Black,
                CornerRadius = 10,
                WidthRequest = 60,
                HeightRequest = 60,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
        };
            snow1 = new BoxView
            {
                BackgroundColor = Color.White,
                CornerRadius = 75,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            snow2 = new BoxView
            {
                BackgroundColor = Color.White,
                CornerRadius = 100,
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
            };
            Xamarin.Forms.Button seen = new Xamarin.Forms.Button
            {
                Text = "Show",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White,
            };
            Xamarin.Forms.Button unseen = new Xamarin.Forms.Button
            {
                Text = "Hide",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White,
            };
            Xamarin.Forms.Button color = new Xamarin.Forms.Button
            {
                Text = "Color ",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White,
            };
           

            AbsoluteLayout abs = new AbsoluteLayout
            {
                Children = { bucket, snow1, snow2, seen, unseen, color}
            };
            AbsoluteLayout.SetLayoutBounds(bucket, new Rectangle(0.5, 0.1, 60, 60));
            AbsoluteLayout.SetLayoutFlags(bucket, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(snow1, new Rectangle(0.5, 0.2, 150, 150));
            AbsoluteLayout.SetLayoutFlags(snow1, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(snow2, new Rectangle(0.5, 0.45, 200, 200));
            AbsoluteLayout.SetLayoutFlags(snow2, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(seen, new Rectangle(0, 0.9, 400, 50));
            AbsoluteLayout.SetLayoutFlags(seen, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(unseen, new Rectangle(0, 0.95, 400, 50));
            AbsoluteLayout.SetLayoutFlags(unseen, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(color, new Rectangle(0, 1, 400, 50));
            AbsoluteLayout.SetLayoutFlags(color, AbsoluteLayoutFlags.PositionProportional);
            Content = abs;

            seen.Clicked += Seen_Clicked;
            unseen.Clicked += Unseen_Clicked;
            color.Clicked += Color_Clicked;
            
        }

        Random rnd;

        private void Color_Clicked(object sender, EventArgs e)
        {
            rnd = new Random();
            snow1.Color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            snow2.Color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void Unseen_Clicked(object sender, EventArgs e)
        {
            bucket.IsVisible = false;
            snow1.IsVisible = false;
            snow2.IsVisible = false;
        }

        private void Seen_Clicked(object sender, EventArgs e)
        {
            bucket.IsVisible = true;
            snow1.IsVisible = true;
            snow2.IsVisible = true;
        }
    }
}

