using Prism;
using Prism.Commands;
using Prism.Common;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TabbedPageLazyLoad.Views;
using Xamarin.Forms;

namespace TabbedPageLazyLoad.ViewModels
{
    public class TabbedPageLazyViewModel : ViewModelBase
    {
        public View currentView { get; set; }
        public TabbedPageLazyViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {

        }
        bool isLoaded { get; set; }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (isLoaded)
            {
                PageUtilities.OnNavigatedTo(currentView, parameters);
            }
            else isLoaded = true;
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            PageUtilities.OnNavigatedFrom(currentView, parameters);
        }


        public override void OnSleep()
        {
            EventAggregator.GetEvent<SleepEvent>().Publish();
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
