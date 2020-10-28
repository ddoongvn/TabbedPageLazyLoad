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
    public class OnlineViewModel : ChildViewModelBase
    {
        public OnlineViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {
            TitlePage = "Online";
            GotoCommand = new DelegateCommand(Goto);
        }

        protected override void RaiseSleepChange()
        {
           
        }

        public string TitlePage { get; set; }
      
        public ICommand GotoCommand { get; }
        private void Goto()
        {
            NavigationService.NavigateAsync("MainPage");
        }
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
