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

        public DataEntryPageThreeViewModel()
        {

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
