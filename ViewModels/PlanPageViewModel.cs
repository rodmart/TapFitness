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
        public DelegateCommand PlanAPICommand { get; set; }

		private ObservableCollection<ExerciseTwo> _exerciseCollectionTwo = new ObservableCollection<ExerciseTwo>();
		public ObservableCollection<ExerciseTwo> ExerciseCollectionTwo
		{
			get { return _exerciseCollectionTwo; }
			set { SetProperty(ref _exerciseCollectionTwo, value); }
		}

        public PlanPageViewModel()
        {
            //INavigationService _navigationService;
            //goes to nothing currently
            PlanAPICommand = new DelegateCommand(SelectPlanFunc);
        }

        internal async void SelectPlanFunc()
        {
			HttpClient client = new HttpClient();

			client.DefaultRequestHeaders.Authorization =
					  new AuthenticationHeaderValue("Token", "a4d10b090f48c641a9590b6c34dcb4e87eb6e4cd");

			var uri = new Uri(
			 string.Format(
					$"https://wger.de/api/v2/exercise/"));

			var response = await client.GetAsync(uri);
			ExerciseTwo exerciseDataTwo = null;

			if (response.IsSuccessStatusCode)
			{
				var contentTwo= await response.Content.ReadAsStringAsync();
				exerciseDataTwo = ExerciseTwo.FromJson(contentTwo);

			}
			ExerciseCollectionTwo.Add(exerciseDataTwo);
			//AddToWeightResults();
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
