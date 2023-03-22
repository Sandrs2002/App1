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
        List<ContentPage> pages = new List<ContentPage>() {new Entry_page(),new Timer_Page(), new BoxView_Page(),
            new Valgusfoor(), new StepperSlider_Page(), new DateTime_Page(), new Lumememm(), new Frame_Page(),
            new Image_Page() };
        List<string> tekstid = new List<string> { "Ava Entry leht","Ava Timer leht", "Ava BoxView leht",
            "Ava Valgusfoor leht", "Ava Stepper.Slider leht", "Ava Date.Time leht", "Ava Lumememm leht",
            "Ava Frame leht", "Ava Image leht"};

        public startpage()
        {
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.DarkSalmon,
            };

            for (int i = 0; i < pages.Count; i++)
            {
                Button button = new Button
                {
                    Text = tekstid[i],
                    TabIndex = i,
                    TextColor = Color.LimeGreen,
                    BackgroundColor = Color.White,
                };
                st.Children.Add(button);
                button.Clicked += Navig_funktsioon;
            }

            Content= st;

        }

        private async void Navig_funktsioon(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            await Navigation.PushAsync(pages[btn.TabIndex]);
        }
        
    }
}