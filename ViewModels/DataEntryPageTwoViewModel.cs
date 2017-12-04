using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace TapFitness.ViewModels
{
    public class DataEntryPageTwoViewModel : BindableBase, INavigationAware
    {
		INavigationService _navigationService;
		public DelegateCommand CompletedQuestionTwoCommand { get; set; }
		public DelegateCommand GoBackCommandTwo { get; set; }


        public DataEntryPageTwoViewModel(INavigationService navigationService)
        {
			_navigationService = navigationService;

			CompletedQuestionTwoCommand = new DelegateCommand(NavToDataEntryPageThree);
			GoBackCommandTwo = new DelegateCommand(GoBackTwo);
        }

		private async void NavToDataEntryPageThree()
		{
			var navParams = new NavigationParameters();
			navParams.Add("NavFromDataPageTwo", "DataEntryPageTwoViewModel");
			await _navigationService.NavigateAsync("DataEntryPageThree", navParams);
		}

		private void GoBackTwo()
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
