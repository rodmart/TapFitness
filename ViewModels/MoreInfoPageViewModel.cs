using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace TapFitness.ViewModels
{
    public class MoreInfoPageViewModel : BindableBase, INavigationAware   
    {
		INavigationService _navigationService;
        //public DelegateCommand GoBackToPlanCommand { get; set; }

        public MoreInfoPageViewModel(INavigationService _navigationService)
        {
            //_navigationService = navigationService;
			//GoBackToPlanCommand = new DelegateCommand(GoBackNav);
		}

		private void GoBackNav()
		{
			//_navigationService.GoBackAsync();
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
