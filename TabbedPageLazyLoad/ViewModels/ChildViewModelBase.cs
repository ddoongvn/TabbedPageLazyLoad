using Prism.Events;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using TabbedPageLazyLoad.Views;

namespace TabbedPageLazyLoad.ViewModels
{
    public class ChildViewModelBase : ViewModelBase
    {
        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value, RaiseIsActiveChanged); }
        }
        public ChildViewModelBase(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {
            EventAggregator.GetEvent<SleepEvent>().Subscribe(RaiseSleepEvent);
        }


        private void RaiseSleepEvent()
        {
            if (_isActive)
            {
                this.RaiseSleepChange();
            }
        }

        protected virtual void RaiseSleepChange()
        {

        }
       

        protected virtual void RaiseIsActiveChanged()
        {

        }
       

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            IsActive = false;
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            IsActive = true;
            base.OnNavigatedTo(parameters);
        }

      
    }
}
