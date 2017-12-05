using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Xamarin.Forms;
namespace TapFitness.ViewModels
{
    public class DataEntryPageTwoViewModel : BindableBase, INavigationAware
    {
        private string _temp;

		public string temp
		{
			get { return _temp; }
			set { SetProperty(ref _temp, value); }
		}

		INavigationService _navigationService;
		public DelegateCommand CompletedQuestionTwoCommand { get; set; }
		public DelegateCommand GoBackCommandTwo { get; set; }


        public DataEntryPageTwoViewModel(INavigationService navigationService)
        {
            temp = Globals.currentWeight;
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

        private void populatePicker(){
            Picker newpick = new Picker();
            for (int i = 0; i < 10;i++)
            {
                newpick.Items.Add(i.ToString());
            }
        }
    }
}
