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
    public partial class Entry_page : ContentPage
    {
        Editor ed;
        Button btn;
        Label lbl;
        public Entry_page()
        {
            ed = new Editor
            {
                Placeholder = "Sisesta siia tekst",
                BackgroundColor = Color.Violet,
                TextColor = Color.PeachPuff
            };
            ed.TextChanged += Ed_TextChanged;
            lbl = new Label
            {
                Text = "Mingi tekst",
                TextColor = Color.DarkGreen,
                BackgroundColor = Color.BlanchedAlmond
            };
            btn= new Button
            {
                Text = "Tagasi"
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { ed ,lbl, btn},
                BackgroundColor = Color.Orange
            };
            Content= st;
            btn.Clicked += Btn_Clicked;
        }
        int i = 0;
        private void Ed_TextChanged(object sender, TextChangedEventArgs e)
        {
            //lbl.Text = ed.Text;
            ed.TextChanged -= Ed_TextChanged;
            char key = e.NewTextValue?.LastOrDefault() ?? ' ';

            if (key == 'A')
            {
                i++;
                lbl.Text = key.ToString() + ": " + i;
            }
        }
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}