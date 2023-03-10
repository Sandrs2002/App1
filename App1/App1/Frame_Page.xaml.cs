using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App1
{	
	public partial class Frame_Page : ContentPage
	{
		Label lbl;
		Frame fr;
		Grid gr;

		public Frame_Page ()
		{
			lbl = new Label
			{
				Text = "Raami kujundus",
				FontSize = Device.GetNamedSize(NamedSize.Subtitle,typeof(Label))
			};

			gr = new Grid
			{
				RowDefinitions =
				{
					new RowDefinition{Height = new GridLength(2, GridUnitType.Star)},
                    new RowDefinition{Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{Height = new GridLength(1, GridUnitType.Star)}
                },
				ColumnDefinitions =
				{
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
                },
			};
			gr.Children.Add(new BoxView { Color = Color.BlueViolet }, 0, 0);
            gr.Children.Add(new BoxView { Color = Color.GreenYellow }, 1, 0);
            gr.Children.Add(new BoxView { Color = Color.Chocolate }, 0, 1);
            gr.Children.Add(new BoxView { Color = Color.Beige }, 1, 1);
            gr.Children.Add(new BoxView { Color = Color.Gold }, 0, 2);
            gr.Children.Add(new BoxView { Color = Color.SteelBlue }, 1, 2);


            fr = new Frame
			{
				Content = gr,
				BorderColor = Color.Aquamarine,
				CornerRadius = 20,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			StackLayout st = new StackLayout
			{
				Children = {lbl, fr }
			};
			Content = st;
		}
	}
}

