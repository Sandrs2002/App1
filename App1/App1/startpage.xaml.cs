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
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Ent_btn },
                BackgroundColor = Color.DarkSalmon,
            };
            Content= st;
            Ent_btn.Clicked += Ent_btn_Clicked;

        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_page());
        }
    }
}