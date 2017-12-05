using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Plugin.TextToSpeech;

namespace TapFitness.ViewModels
{
    public class DataSummaryPageViewModel : BindableBase, INavigationAware
    {

        private string _fitnessGoal;
        private string _currentWeight;
        private string _goalWeight;
        private string _activityLevel;


        public DelegateCommand GoBackCommandTwo { get; set; }
        public DelegateCommand GoBackRootDataCommand { get; set;}
        public DelegateCommand TextToSpeechCommand { get; set; }





        public string fitnessGoal
		{
			get { return _fitnessGoal; }
			set { SetProperty(ref _fitnessGoal, value); }
		}
		public string currentWeight
		{
			get { return _currentWeight; }
			set { SetProperty(ref _currentWeight, value); }
		}
		public string goalWeight
		{
			get { return _goalWeight; }
			set { SetProperty(ref _goalWeight, value); }
		}
		public string activityLevel
		{
			get { return _activityLevel; }
			set { SetProperty(ref _activityLevel, value); }
		}

		private string _TextToSpeech;
		public string TextToSpeech
		{
            get { return _TextToSpeech; }
            set { SetProperty(ref _TextToSpeech, value); }
		}

		INavigationService _navigationService;
		public DelegateCommand CompletedQuestionThreeCommand { get; set; }

        public DataSummaryPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            fitnessGoal = "Fitness Goal: " + Globals.fitnessGoals;
            currentWeight = "Current Weight: " + Globals.currentWeight;
            goalWeight = "Goal Weight: " + Globals.goalWeight;
            activityLevel = "Activity Level: " + Globals.activityLevel;
            GoBackRootDataCommand = new DelegateCommand(GoBackRootData);
            TextToSpeechCommand = new DelegateCommand(TextToSpeechFunc);

        }

        private void TextToSpeechFunc()
        {
            // var SpeechText = TextToSpeechEntry.Text;
            //CrossTextToSpeech.Current.Speak(SpeechText);
            CrossTextToSpeech.Current.Speak(TextToSpeech);
        }

		private async void GoBackRootData()
		{
			var navParams = new NavigationParameters();
			navParams.Add("NavFromSummaryPage", "DataSummaryPageViewModel");
			await _navigationService.NavigateAsync("DataEntryPageOne", navParams);
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
