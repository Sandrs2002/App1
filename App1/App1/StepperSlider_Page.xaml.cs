using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App1
{
	public partial class StepperSlider_Page : ContentPage
	{
		Label lbl;
		Slider sld;
		Stepper stp;
		public StepperSlider_Page()
		{
			lbl = new Label
			{
				Text = "...",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			sld = new Slider
			{
				Minimum = 0,
				Maximum = 100,
				Value = 30,
				MinimumTrackColor = Color.White,
				MaximumTrackColor = Color.Black,
				ThumbColor = Color.Purple,
			};
			sld.ValueChanged += Sld_ValueChanged;
			stp = new Stepper
			{
				Minimum = 0,
				Maximum = 100,
				Increment = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			stp.ValueChanged += Stp_ValueChanged;
			StackLayout st = new StackLayout
			{
				Children = {sld, lbl, stp}
			};
			Content = st;
		}

		private void Stp_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			lbl.Text = String.Format("Valitud: {0:F1}", e.NewValue);
			lbl.FontSize = e.NewValue;
			lbl.Rotation = e.NewValue;
		}

		private void Sld_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			lbl.Text = String.Format("Valitud: {0:F1}", e.NewValue);
			lbl.FontSize = e.NewValue;
			lbl.Rotation = e.NewValue;
		}
	}
}
