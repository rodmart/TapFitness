using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace TapFitness.ViewModels
{
    public class DataSummaryPageViewModel : BindableBase, INavigationAware
    {
		INavigationService _navigationService;
		public DelegateCommand CompletedQuestionThreeCommand { get; set; }

        public DataSummaryPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
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
