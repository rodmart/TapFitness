using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Prism.Navigation;

using static TapFitness.Models.ExerciseItemModelTwo;

namespace TapFitness.ViewModels
{
    public class TestPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;
        public DelegateCommand LastGoBackCommand { get; set; }

		private Result _result;
		public Result Result
		{
            get { return _result; }
            set { SetProperty(ref _result, value); }
		}

        public TestPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LastGoBackCommand = new DelegateCommand(gobackFunc);
        }

		private void gobackFunc()
		{
			_navigationService.GoBackAsync();
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("ExerciseItemInfo"))
            {
                Result = (Result)parameters["ExerciseItemInfo"];
			}
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
		}
    }
}
