using Prism;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace TabbedPageLazyLoad.ViewModels
{
    public class HomeViewModel : ChildViewModelBase
    {
        public HomeViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {
            TitlePage = "HOme";
        }

        protected override void RaiseIsActiveChanged()
        {
            base.RaiseIsActiveChanged();
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
