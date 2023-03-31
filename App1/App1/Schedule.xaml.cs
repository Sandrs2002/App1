using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace App1
{	
	public partial class Schedule : ContentPage
	{
        Xamarin.Forms.TimePicker tp;
        Image img, img2, img3;
        Label lbl;
        
        public Schedule ()
		{
            lbl = new Label
            {
                Text = " "
            };
            img = new Image
            {
                Source = "schedule.jpg"
            };
            img2 = new Image
            {
                Source = "schedule.jpg"
            };
            img3 = new Image
            {
                Source = "schedule.jpg"
            };
            tp = new Xamarin.Forms.TimePicker
            {
                Time = new TimeSpan(00, 0, 0)
            };
            tp.PropertyChanged += Tp_PropertyChanged;
            AbsoluteLayout abs = new AbsoluteLayout
            {
                Children = { tp, lbl, img, img2, img3 }
            };
            AbsoluteLayout.SetLayoutBounds(tp, new Rectangle(0.5, 0.05, 200, 50));
            AbsoluteLayout.SetLayoutFlags(tp, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0.5, 0.15, 200, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(img, new Rectangle(0.5, 0.3, 400, 200));
            AbsoluteLayout.SetLayoutFlags(img, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(img2, new Rectangle(0.5, 0.6, 400, 200));
            AbsoluteLayout.SetLayoutFlags(img2, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(img3, new Rectangle(0.5, 0.9, 400, 200));
            AbsoluteLayout.SetLayoutFlags(img3, AbsoluteLayoutFlags.PositionProportional);
            Content = abs;
        }

        private void Tp_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            int h = tp.Time.Hours;
            int m = tp.Time.Minutes;
            if (h == 7)
            {
                lbl.Text = "Waking up at 7, Usin bathroom till 7.15, Breakfast till 7.40";
                img.Source = "one.jpg";
                img2.Source = "four.jpg";
                img3.Source = "three.jpg";
                img2.IsVisible = true;
                img3.IsVisible = true;
            }
            else if ( h == 8)
            {
                lbl.Text = "Going to work";
                img.Source = "six.jpg";
                img2.IsVisible = false;
                img3.IsVisible = false;
            }
            else if ( h >= 9 & h < 13)
            {
                lbl.Text = "Working";
                img.Source = "seven.jpg";
                img2.IsVisible = false;
                img3.IsVisible = false;
            }
            else if ( h == 13)
            {
                lbl.Text = "lunch";
                img.Source = "eight.jpg";
                img2.IsVisible = false;
                img3.IsVisible = false;
            }
            else if ( h >= 14 & h < 18)
            {
                lbl.Text = "Working";
                img.Source = "eight.jpg";
                img2.IsVisible = false;
                img3.IsVisible = false;
            }
            else if ( h == 18)
            {
                lbl.Text = "Going home";
                img.Source = "six.jpg";
                img2.IsVisible = false;
                img3.IsVisible = false;
            }
            else if (h == 19)
            {
                lbl.Text = "Getting home at 19, Having shower at 19.30";
                img.Source = "ten.jpg";
                img2.Source = "two.jpg";
                img2.IsVisible = true;
                img3.IsVisible = false;
            }
            else if ( h == 20)
            {
                lbl.Text = "Dinner";
                img.Source = "eleven.jpg";
                img2.IsVisible = false;
                img3.IsVisible = false;
            }
            else if ( h == 21)
            {
                lbl.Text = "Homework(if I have it)";
                img.Source = "fourteen.jpg";
                img2.IsVisible = false;
                img3.IsVisible = false;
            }
            else if (h == 22)
            {
                lbl.Text = "Free time";
                img.Source = "twelwe.jpg";
                img2.IsVisible = false;
                img3.IsVisible = false;
            }
            else if (h == 23)
            {
                lbl.Text = "Getting ready to sleep/Sleeping";
                img.Source = "thirteen.jpg";
                img2.IsVisible = false;
                img3.IsVisible = false;
            }
            else 
            {
                lbl.Text = "Sleeping";
                img.Source = "thirteen.jpg";
                img2.IsVisible = false;
                img3.IsVisible = false;
            }

        }

    }

}

