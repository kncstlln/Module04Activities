﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03Module04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity03 : ContentPage
    {
        public Activity03()
        {
            InitializeComponent();
        }

        private async void onNextPage (object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Activity03Page2());
        }

        private async void onPreviousPage(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}