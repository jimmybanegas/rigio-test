﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RigioREST.Data;
using Xamarin.Forms;

namespace RigioREST
{
    public partial class App : Application
    {
        public static AccountManager AccountManager { get; private set; }

        public App()
        {
            InitializeComponent();

            AccountManager = new AccountManager(new AccountService());
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
