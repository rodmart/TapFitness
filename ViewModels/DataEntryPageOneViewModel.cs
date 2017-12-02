using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace TapFitness.ViewModels
{
    public class DataEntryPageOneViewModel : BindableBase, INavigationAware
    {
       
		INavigationService _navigationService;
		public DelegateCommand CompletedQuestionOneCommand { get; set; }
        public DelegateCommand GoBackCommand { get; set; }
        //goback2 gages note

        public DataEntryPageOneViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            CompletedQuestionOneCommand = new DelegateCommand(NavToDataEntryPageTwo);
            GoBackCommand = new DelegateCommand(GoBack);
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
