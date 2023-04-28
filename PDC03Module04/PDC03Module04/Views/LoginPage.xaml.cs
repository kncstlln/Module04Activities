﻿using PDC03Module04.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03Module04.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}