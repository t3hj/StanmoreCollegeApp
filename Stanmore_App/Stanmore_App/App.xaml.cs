﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stanmore_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AboutUs());
        }



        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
