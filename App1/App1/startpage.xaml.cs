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
                Text="Ava Timer leht",
                TextColor= Color.DarkSeaGreen,
                BackgroundColor= Color.BlanchedAlmond
            };
            Button Box_btn = new Button
            {
                Text = "Ava Box leht",
                TextColor = Color.DarkOliveGreen,
                BackgroundColor = Color.BlanchedAlmond
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Ent_btn, Timer_btn, Box_btn },
                BackgroundColor = Color.DarkSalmon,
            };
            Content= st;
            Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            Box_btn.Clicked += Box_btn_Clicked;
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