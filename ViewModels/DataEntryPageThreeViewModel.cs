using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace TapFitness.ViewModels
{
    public class DataEntryPageThreeViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;
		public DelegateCommand CompletedQuestionThreeCommand { get; set; }
		public DelegateCommand GoBackCommandThree { get; set; }

        public DataEntryPageThreeViewModel(INavigationService navigationService)
        {
			_navigationService = navigationService;

			CompletedQuestionThreeCommand = new DelegateCommand(NavToDataSummaryPage);
			GoBackCommandThree = new DelegateCommand(GoBackThree);
        }

		private async void NavToDataSummaryPage()
		{
			var navParams = new NavigationParameters();
			navParams.Add("NavFromDataPageThree", "DataEntryPageThreeViewModel");
			await _navigationService.NavigateAsync("DataSummaryPage", navParams);
		}

		private void GoBackThree()
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
