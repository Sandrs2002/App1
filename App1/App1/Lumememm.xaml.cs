using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using static System.Net.Mime.MediaTypeNames;

namespace App1
{
    public partial class Lumememm : ContentPage
    {
        Frame bucket, snow1, snow2;
        Stepper stp;
        Switch sw;
        Label lbl;
        public Lumememm()
        {
            BackgroundImageSource = "snowmount.jpg";
            lbl = new Label
            {
                Text = " ",
                TextColor = Color.White,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            bucket = new Frame()
            {
                BackgroundColor = Color.Black,
                CornerRadius = 10,
                WidthRequest = 60,
                HeightRequest = 60,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                Padding = 30,
            };
            snow1 = new Frame()
            {
                BackgroundColor = Color.White,
                CornerRadius = 75,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Padding = 30
            };
            snow2 = new Frame()
            {
                BackgroundColor = Color.White,
                CornerRadius = 100,
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
                Padding = 30,
                Content = lbl
            };
            TapGestureRecognizer memm = new TapGestureRecognizer();
            memm.Tapped += Memm_Tapped;
            snow2.GestureRecognizers.Add(memm);

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
            stp = new Stepper
            {
                Minimum = 0,
                Maximum = 100,
                Increment = 5,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            stp.ValueChanged += Stp_ValueChanged1;
            sw = new Switch
            {
                IsToggled = true,
                VerticalOptions = LayoutOptions.EndAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            sw.Toggled += Sw_Toggled;

            AbsoluteLayout abs = new AbsoluteLayout
            {
                Children = { bucket, snow1, snow2, sw, stp, seen, unseen, color }
            };
            AbsoluteLayout.SetLayoutBounds(bucket, new Rectangle(0.5, 0.1, 60, 60));
            AbsoluteLayout.SetLayoutFlags(bucket, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(snow1, new Rectangle(0.5, 0.2, 150, 150));
            AbsoluteLayout.SetLayoutFlags(snow1, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(snow2, new Rectangle(0.5, 0.45, 200, 200));
            AbsoluteLayout.SetLayoutFlags(snow2, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(sw, new Rectangle(0.5, 0.7, 60, 60));
            AbsoluteLayout.SetLayoutFlags(sw, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(stp, new Rectangle(0, 0.8, 400, 50));
            AbsoluteLayout.SetLayoutFlags(stp, AbsoluteLayoutFlags.PositionProportional);
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

        private void Stp_ValueChanged1(object sender, ValueChangedEventArgs e)
        {
            bucket.WidthRequest = stp.Value;
            snow1.WidthRequest = stp.Value;
            snow2.WidthRequest = stp.Value;
        }

        private void Memm_Tapped(object sender, EventArgs e)
        {
            if(snow2.BackgroundColor == Color.Blue)
            {
                lbl.Text = "Someone broke me";
                lbl.TextColor = Color.White;
            }
            else
            {
                lbl.Text = " ";
            }
        }

        private void Sw_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                BackgroundImageSource = "snowmount.jpg";
                AbsoluteLayout.SetLayoutBounds(bucket, new Rectangle(0.5, 0.1, 60, 60));
                AbsoluteLayout.SetLayoutFlags(bucket, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(snow1, new Rectangle(0.5, 0.2, 150, 150));
                AbsoluteLayout.SetLayoutFlags(snow1, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(snow2, new Rectangle(0.5, 0.45, 200, 200));
                AbsoluteLayout.SetLayoutFlags(snow2, AbsoluteLayoutFlags.PositionProportional);
                snow1.BackgroundColor = Color.White;
                snow2.BackgroundColor = Color.White;
            }
            else
            {
                BackgroundImageSource = "snowview.jpg";
                snow1.BackgroundColor = Color.Blue;
                snow2.BackgroundColor = Color.Blue;
                bucket.BackgroundColor = Color.Gray;
                AbsoluteLayout.SetLayoutBounds(bucket, new Rectangle(0, 0.6, 60, 60));
                AbsoluteLayout.SetLayoutFlags(bucket, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(snow1, new Rectangle(0.2, 0.6, 150, 150));
                AbsoluteLayout.SetLayoutFlags(snow1, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(snow2, new Rectangle(1, 0.6, 200, 200));
                AbsoluteLayout.SetLayoutFlags(snow2, AbsoluteLayoutFlags.PositionProportional);

            }
        }


        Random rnd;

        private void Color_Clicked(object sender, EventArgs e)
        {
            rnd = new Random();
            snow1.BackgroundColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            snow2.BackgroundColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
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
            snow1.BackgroundColor = Color.White;
            snow2.BackgroundColor = Color.White;
        }
    }
}

