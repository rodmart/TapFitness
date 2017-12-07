using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Net.Http;
using Xamarin.Forms;
namespace TapFitness.ViewModels
{
    public class DataEntryPageOneViewModel : BindableBase, INavigationAware
    {
       
		INavigationService _navigationService;
		public DelegateCommand CompletedQuestionOneCommand { get; set; }
        public DelegateCommand GoBackCommand { get; set; }
        public DelegateCommand<Picker> ItemSelectedCommand { get; set; }
		//goback2 gages note


		


        private string _currweightEnteredByUser;
        public string CurrWeightEnteredByUser
		{
            get { return _currweightEnteredByUser; }
            set
            {
                SetProperty(ref _currweightEnteredByUser, value);
                Globals.currentWeight = value;
            }
		}

        private string _goalweightEnteredByUser;
		public string GoalWeightEnteredByUser
		{
            get { return _goalweightEnteredByUser; }
            set
            {
                SetProperty(ref _goalweightEnteredByUser, value);
                Globals.goalWeight = value;
            }
		}

        public DataEntryPageOneViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            CompletedQuestionOneCommand = new DelegateCommand(NavToDataEntryPageTwo);
            GoBackCommand = new DelegateCommand(GoBack);
            ItemSelectedCommand = new DelegateCommand<Picker> (ItemSelected);
        }
        private void ItemSelected(Object item)
		{
            Globals.fitnessGoals = " random";
		}
		private async void NavToDataEntryPageTwo()
		{
			var navParams = new NavigationParameters();
			navParams.Add("NavFromDataPageOne", "DataEntryPageOneViewModel");
			await _navigationService.NavigateAsync("DataEntryPageTwo", navParams);
		}

		private void GoBack()
		{
			_navigationService.GoBackAsync();
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
