﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03Module04
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        private async void OpenActivity1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity01());
        }
        private async void OpenActivity2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity2());
        }

        private async void OpenActivity3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity03());
        }
        private async void OpenActivity4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity04());
        }
        private async void OpenActivity5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity05());
        }
    }
}