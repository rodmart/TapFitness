using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace TapFitness.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        private string _Welcome;
        private string _Intro;
        private string _Intro2;
        private string _Intro3;
        private string _Swipe;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public string welcome
        {
            get { return _Welcome; }
            set { SetProperty(ref _Welcome, value); }
        }
        public string Intro
        {
            get { return _Intro; }
            set { SetProperty(ref _Intro, value); }
        }
        public string Intro2
        {
            get { return _Intro2; }
            set { SetProperty(ref _Intro2, value); }
        }
        public string Intro3
        {
            get { return _Intro3; }
            set { SetProperty(ref _Intro3, value); }
        }
        public string swipe
        {
            get { return _Swipe; }
            set { SetProperty(ref _Swipe, value); }
        }
        public MainPageViewModel(INavigationService navigationService)
        {
            Title= "BGR.TapFitness";
            welcome="WELCOME To TapFitness";
            Intro = "Glad to have you on board. ";


            Intro2 = "You have taken the first step to improve";
            Intro3="your health.";

            swipe="swipe left to begin.";
        }

      
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}

