using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Unity;
using TapFitness.Views;

namespace TapFitness
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync($"MainPage");
          
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<DataEntryPageOne>();
            Container.RegisterTypeForNavigation<DataEntryPageTwo>();
            Container.RegisterTypeForNavigation<DataEntryPageThree>();
            Container.RegisterTypeForNavigation<DataSummaryPage>();
            Container.RegisterTypeForNavigation<PlanPage>();
            Container.RegisterTypeForNavigation<TestPage>();

            //Container.RegisterTypeForNavigation<MoreInfoPage>();
        }
    }
}

