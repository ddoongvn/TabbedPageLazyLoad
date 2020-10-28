using Prism;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TabbedPageLazyLoad.ViewModels
{
    public class AccountViewModel : ChildViewModelBase
    {
        public AccountViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {
            TitlePage = "Account";
        }

        protected override void RaiseIsActiveChanged()
        {
            
        }
        protected override void RaiseSleepChange()
        {
            base.RaiseSleepChange();
        }

        public string TitlePage { get; set; }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {           
            base.OnNavigatedTo(parameters);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {           
            base.OnNavigatedFrom(parameters);
        }

        public override void OnSleep()
        {
            base.OnSleep();
        }

        public override void Destroy()
        {
            base.Destroy();
        }


        public override void OnResume()
        {
            base.OnResume();
        }
    }
}
