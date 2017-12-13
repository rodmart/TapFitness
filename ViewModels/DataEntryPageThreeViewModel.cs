using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Xamarin.Forms;
namespace TapFitness.ViewModels
{
    public class DataEntryPageThreeViewModel : BindableBase, INavigationAware
    {
        private string _temp;

        public string temp
        {
            get { return _temp; }
            set { SetProperty(ref _temp, value); }
        }

        INavigationService _navigationService;
		public DelegateCommand CompletedQuestionThreeCommand { get; set; }
		public DelegateCommand GoBackCommandThree { get; set; }


        public DataEntryPageThreeViewModel(INavigationService navigationService)
        {
            temp = Globals.TimeLevel;
			_navigationService = navigationService;
			CompletedQuestionThreeCommand = new DelegateCommand(NavToDataSummaryPage);
			GoBackCommandThree = new DelegateCommand(GoBackThree);
        }

        public async void NavToDataSummaryPage()
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
        private void populatePicker()
        {
            Picker newpick = new Picker();
            for (int i = 0; i < 10; i++)
            {
                newpick.Items.Add(i.ToString());
            }
        }
    }
}
