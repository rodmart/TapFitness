﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Unity;
using TapFitness.Views;

namespace TapFitness
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            //NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
            NavigationService.NavigateAsync($"MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
        }
    }
}

