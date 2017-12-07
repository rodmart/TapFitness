using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Net.Http;
using System.Net.Http.Headers;
using static TapFitness.Models.ExerciseItemModel;

namespace TapFitness.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        private string _Welcome;
        private string _Intro;
        private string _Swipe;
        private string _paragraph;
        private string _temp;

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

        public string swipe
        {
            get { return _Swipe; }
            set { SetProperty(ref _Swipe, value); }
        }

        public string paragraph1
        {
            get { return _paragraph; }
            set { SetProperty(ref _paragraph, value); }
        }
		public string temp
		{
			get { return _temp; }
			set { SetProperty(ref _temp, value); }
		}

		private ObservableCollection<Exercise> _exerciseCollection = new ObservableCollection<Exercise>();
		public ObservableCollection<Exercise> ExerciseCollection
		{
			get { return _exerciseCollection; }
			set { SetProperty(ref _exerciseCollection, value); }
		}

        INavigationService _navigationService;
        public DelegateCommand ContinueCommand { get; set; }
        //
        public DelegateCommand apiTestCommand { get; set; }
        //

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;


            Title= "BGR.TapFitness";
            welcome="WELCOME To TapFitness";
            Intro = "Glad to have you on board." +
                "You have taken the first step to improve" +
                "your health.";

            swipe="swipe left to begin.";
            paragraph1 = "In the next few pages we will have you enter " +
                "your information in order for us to compile all your " +
                "infomation to give you the best possible solution.";
            temp = Globals.fitnessGoals;
            ContinueCommand = new DelegateCommand(NavToDataEntryPageOne);
            apiTestCommand = new DelegateCommand(GetUserinfo);
           
        }


        private async void NavToDataEntryPageOne()
        {
            var navParams = new NavigationParameters();
            navParams.Add("NavFromDataMainPage", "MainPageViewModel");
            await _navigationService.NavigateAsync("DataEntryPageOne", navParams);
        }

        public string ExerciseForUser; //needs to be implemented

       // private Exercise _exerciseItem;
       // public Exercise ExerciseItem
       // {
       //    get { return _exerciseItem; }
       //     set { SetProperty(ref _exerciseItem, value); }
       // }

		private string _PlankTest;
		public string PlankTest
		{
			get { return _PlankTest; }
			set
			{
				SetProperty(ref _PlankTest, value);
				//Globals.currentWeight = value;
			}
		}

        internal async void GetUserinfo()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization =
                      new AuthenticationHeaderValue("Token", "a4d10b090f48c641a9590b6c34dcb4e87eb6e4cd");

            var uri = new Uri(
             string.Format(
                    $"https://wger.de/api/v2/weightentry/"));
            
			var response = await client.GetAsync(uri);
            Exercise exerciseData = null;

           if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                exerciseData = Exercise.FromJson(content);
               
            }
            ExerciseCollection.Add(exerciseData);
			AddToWeightResults();
        }

		private void AddToWeightResults()
		{
			foreach (var exercise in ExerciseCollection)
			{
				WeightResults.Add(exercise.Results[0]);
			}
		}

		private ObservableCollection<Result> _weightResults = new ObservableCollection<Result>();
		public ObservableCollection<Result> WeightResults
		{
			get { return _weightResults; }
			set { SetProperty(ref _weightResults, value); }
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

