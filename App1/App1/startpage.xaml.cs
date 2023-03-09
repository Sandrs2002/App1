using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class startpage : ContentPage
    {
        public startpage()
        {
            //InitializeComponent();
            Button Ent_btn = new Button
            {
                Text = "Ava Entry leht",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White
            };
            Button Timer_btn = new Button
            {
                Text = "Ava Timer leht",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White
            };
            Button Box_btn = new Button
            {
                Text = "Ava Box leht",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White
            };
            Button Foor_btn = new Button
            {
                Text = "Ava valgusfoor",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White
            };
            Button Stepper_btn = new Button
            {
                Text = "Ava Stepper.Slider leht",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White
            };
            Button Datetime_btn = new Button
            {
                Text = "Ava Date.Time leht",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White
            };
            Button Lumememm_btn = new Button
            {
                Text = "Ava Lumememm leht",
                TextColor = Color.LimeGreen,
                BackgroundColor = Color.White
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Ent_btn, Timer_btn, Box_btn, Foor_btn, Stepper_btn, Datetime_btn, Lumememm_btn},
                BackgroundColor = Color.DarkSalmon,
            };
            Content= st;
            Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            Box_btn.Clicked += Box_btn_Clicked;
            Foor_btn.Clicked += Foor_btn_Clicked;
            Stepper_btn.Clicked += Stepper_btn_Clicked;
            Datetime_btn.Clicked += Datetime_btn_Clicked;
            Lumememm_btn.Clicked += Lumememm_btn_Clicked;

        }

        private async void Lumememm_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Datetime_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Stepper_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Foor_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Valgusfoor());
        }

        private async void Box_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxView_Page());
        }

        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer_Page());
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new Entry_page());
        }
    }
}