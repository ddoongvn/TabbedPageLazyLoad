using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using TabbedPageLazyLoad.Views;

namespace TabbedPageLazyLoad.ViewModels
{
    public class VehicleViewModel : ChildViewModelBase
    {
        public VehicleViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {
            TitlePage = "Vehicle";
            PopupCommand = new DelegateCommand(Popup);
        }
        private void Popup()
        {
           // NavigationService.NavigateAsync("TestPopup");
            PopupNavigation.Instance.PushAsync(new TestPopup());
        }
        public string TitlePage { get; set; }

        public ICommand PopupCommand { get; }
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
