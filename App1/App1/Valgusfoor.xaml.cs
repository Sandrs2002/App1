using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace App1
{
    public partial class Valgusfoor : ContentPage
    {
        Frame pun, kol, roh;
        Label lbp, lbk, lbr;

        
        public Valgusfoor()
        {
            InitializeComponent();
            Button sisse_bnt = new Button
            {
                Text = "Sisse",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White
            };
            Button valja_bnt = new Button
            {
                Text = "Välja",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White
            };

            lbp = new Label()
            {
                Text = "punane",
                TextColor = Color.Gray,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            pun = new Frame
            {
                BackgroundColor = Color.FromRgb(160, 160, 160),
                CornerRadius = 70,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                Content = lbp

            };
            TapGestureRecognizer tap1 = new TapGestureRecognizer();
            tap1.Tapped += Tap1_Tapped;
            pun.GestureRecognizers.Add(tap1);

            lbk = new Label()
            {
                Text = "kollane",
                TextColor = Color.Gray,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            kol = new Frame
            {
                BackgroundColor = Color.FromRgb(160, 160, 160),
                CornerRadius = 70,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = lbk
            };
            TapGestureRecognizer tap2 = new TapGestureRecognizer();
            tap2.Tapped += Tap2_Tapped;
            kol.GestureRecognizers.Add(tap2);

            lbr = new Label()
            {
                Text = "roheline",
                TextColor = Color.Gray,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            roh = new Frame
            {
                BackgroundColor = Color.FromRgb(160, 160, 160),
                CornerRadius = 70,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
                Content = lbr
            };
            TapGestureRecognizer tap3 = new TapGestureRecognizer();
            tap3.Tapped += Tap3_Tapped;
            roh.GestureRecognizers.Add(tap3);

            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { pun, kol, roh, sisse_bnt, valja_bnt}
            };

            Content = st;
            sisse_bnt.Clicked += Sisse_bnt_Clicked;
            valja_bnt.Clicked += Valja_bnt_Clicked;
        }

        private void Valja_bnt_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.FromRgb(160, 160, 160);
            kol.BackgroundColor = Color.FromRgb(160, 160, 160);
            roh.BackgroundColor = Color.FromRgb(160, 160, 160);
        }

        private void Sisse_bnt_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.FromRgb(255, 0, 0);
            kol.BackgroundColor = Color.FromRgb(255, 255, 0);
            roh.BackgroundColor = Color.FromRgb(0, 255, 0);
        }

        private void Tap1_Tapped(object sender, EventArgs e)
        {
            
                if (pun.BackgroundColor == Color.FromRgb(255, 0, 0))
                {
                    lbp.Text = "Stop!";
                    lbp.TextColor = Color.DarkRed;
                }
                else
                {
                    lbp.Text = "Lülita valgusfoor sisse!";
                    lbp.TextColor = Color.Gray;
                }
        }
        private void Tap2_Tapped(object sender, EventArgs e)
        {
            if (kol.BackgroundColor == Color.FromRgb(255, 255, 0))
            {
                lbk.Text = "Wait!";
                lbk.TextColor = Color.Goldenrod;
            }
            else if (kol.BackgroundColor == Color.FromRgb(160, 160, 160))
            {
                lbk.Text = "Lülita valgusfoor sisse!";
                lbp.TextColor = Color.Gray;
            }
        }
        private void Tap3_Tapped(object sender, EventArgs e)
        {
            if (roh.BackgroundColor == Color.FromRgb(0, 255, 0))
            {
                lbr.Text = "Go!";
                lbr.TextColor = Color.Green;
            }
            else if (roh.BackgroundColor == Color.FromRgb(160, 160, 160))
            {
                lbr.Text = "Lülita valgusfoor sisse!";
                lbp.TextColor = Color.Gray;
            }
        }
    }
}

