using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class Timer_Page : ContentPage
    {
        public Timer_Page()
        {
            InitializeComponent();
        }
        bool on_off = false;
        public async void ShowTime()
        {
            while (on_off)
            {
                lbl.Text = DateTime.Now.ToString("G");
                await Task.Delay(1000);
            }
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            if (on_off)
            {
                on_off = false;
            }
            else
            {
                on_off = true;
                ShowTime();
            }
        }
    }
}

