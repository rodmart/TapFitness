﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.ObjectModel;

using static TapFitness.Models.ExerciseItemModelTwo;

namespace TapFitness.ViewModels
{
    public class PlanPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;
        public DelegateCommand PlanAPICommand { get; set; }
        public DelegateCommand<Result> DeleteCellCommand { get; set; }
        public DelegateCommand ClickThisCommand { get; set; }
        public DelegateCommand<Result> MoreCellCommand { get; set; }

		private ObservableCollection<ExerciseTwo> _exerciseCollectionTwo = new ObservableCollection<ExerciseTwo>();
		public ObservableCollection<ExerciseTwo> ExerciseCollectionTwo
		{
			get { return _exerciseCollectionTwo; }
			set { SetProperty(ref _exerciseCollectionTwo, value); }
		}

		private ObservableCollection<Result> _exerciseResults = new ObservableCollection<Result>();
		public ObservableCollection<Result> ExerciseResults
		{
			get { return _exerciseResults; }
            set { SetProperty(ref _exerciseResults, value); }
		}

        public PlanPageViewModel(INavigationService navigationService)
        {
			_navigationService = navigationService;
            ClickThisCommand = new DelegateCommand(trythis);
            PlanAPICommand = new DelegateCommand(SelectPlanFunc);
            DeleteCellCommand = new DelegateCommand<Result>(DeleteCellFunc);
            MoreCellCommand = new DelegateCommand<Result>(MoreCellFunc);
        }



		private async void trythis()
		{
			var navParams = new NavigationParameters();
			navParams.Add("NavFromPage", "PlanPageViewModel");
			await _navigationService.NavigateAsync("TestPage", navParams);
		}

        private async void MoreCellFunc(Result result)
        {
			var navParams = new NavigationParameters();
			navParams.Add("ExerciseItemInfo", result);
			await _navigationService.NavigateAsync("TestPage", navParams);
        }

        private void DeleteCellFunc(Result result)
		{
            Result exerciseDataTwo = result;
            ExerciseResults.Remove(exerciseDataTwo);
		}

        internal async void SelectPlanFunc()
        {
			HttpClient client = new HttpClient();

			client.DefaultRequestHeaders.Authorization =
					  new AuthenticationHeaderValue("Token", "a4d10b090f48c641a9590b6c34dcb4e87eb6e4cd");

			var uri = new Uri(
			 string.Format(
					$"https://wger.de/api/v2/exercise/"));

			var responsetwo = await client.GetAsync(uri);
			ExerciseTwo exerciseDataTwo = null;

			if (responsetwo.IsSuccessStatusCode)
			{
				var contentTwo = await responsetwo.Content.ReadAsStringAsync();
				exerciseDataTwo = ExerciseTwo.FromJson(contentTwo);

			}
			ExerciseCollectionTwo.Add(exerciseDataTwo);
			AddToExerciseResults();
        }

        private void AddToExerciseResults()
        {
            //logic based on data goes here (our api sucks) -gage
            //start

            //end

            foreach (var exercisetwo in ExerciseCollectionTwo)
            {
                
                if (Globals.fitnessGoals == "Lose weight healthy")
                {
                    ExerciseResults.Add(exercisetwo.Results[4]);
                    ExerciseResults.Add(exercisetwo.Results[2]);
                    ExerciseResults.Add(exercisetwo.Results[3]);
                    ExerciseResults.Add(exercisetwo.Results[19]);
                }

                if (Globals.fitnessGoals == "Gain weight healthy")
                {
                    ExerciseResults.Add(exercisetwo.Results[4]);
                    ExerciseResults.Add(exercisetwo.Results[2]);
                    ExerciseResults.Add(exercisetwo.Results[11]);
					ExerciseResults.Add(exercisetwo.Results[12]);
                }
                if (Globals.fitnessGoals == "Same weight but healthy")
                {
                    ExerciseResults.Add(exercisetwo.Results[4]);
                    ExerciseResults.Add(exercisetwo.Results[2]);
                    ExerciseResults.Add(exercisetwo.Results[8]);
                    ExerciseResults.Add(exercisetwo.Results[12]);
                    ExerciseResults.Add(exercisetwo.Results[13]);
                    ExerciseResults.Add(exercisetwo.Results[19]);
                }
                else if (Globals.fitnessGoals == "")
                {
                    ExerciseResults.Add(exercisetwo.Results[4]);
                    ExerciseResults.Add(exercisetwo.Results[2]);
                    ExerciseResults.Add(exercisetwo.Results[3]);
                    ExerciseResults.Add(exercisetwo.Results[11]);
                    ExerciseResults.Add(exercisetwo.Results[8]);
                    ExerciseResults.Add(exercisetwo.Results[12]);
                    ExerciseResults.Add(exercisetwo.Results[13]);
                    ExerciseResults.Add(exercisetwo.Results[19]);
                }
            }
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
