using Prism.Commands;
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
        //public DelegateCommand <Result>NavToMoreInfoCommand { get; set; }
        public DelegateCommand GoBackToPlanCommand { get; set; }

        public DelegateCommand TestNavCommand { get; set; }

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
            //goes to nothing currently
            PlanAPICommand = new DelegateCommand(SelectPlanFunc);
            DeleteCellCommand = new DelegateCommand<Result>(DeleteCellFunc);
           
           // NavToMoreInfoCommand = new DelegateCommand<Result>(NavToMoreInfoFunc);
           // GoBackToPlanCommand = new DelegateCommand(GoBackNav);
        }




		//private async void NavToMoreInfoFunc(Result result)
		//{
		//	var navParams = new NavigationParameters();
		//	 navParams.Add("ExerciseItemInfo", result);
		//	await _navigationService.NavigateAsync("MoreInfoPage", navParams);
	//	}


        private void DeleteCellFunc(Result result)
		{
            Result exerciseDataTwo = result;
            ExerciseResults.Remove(exerciseDataTwo);
            //ExerciseCollectionTwo.Remove(something);
			//WeatherItem weatherData = weatherItem;
			//WeatherCollection.Remove(weatherData);
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
                ExerciseResults.Add(exercisetwo.Results[4]);
                //
                ExerciseResults.Add(exercisetwo.Results[2]);
                ExerciseResults.Add(exercisetwo.Results[3]);
                ExerciseResults.Add(exercisetwo.Results[11]);
                ExerciseResults.Add(exercisetwo.Results[8]);
                ExerciseResults.Add(exercisetwo.Results[12]);
                ExerciseResults.Add(exercisetwo.Results[13]);
                ExerciseResults.Add(exercisetwo.Results[19]);
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
