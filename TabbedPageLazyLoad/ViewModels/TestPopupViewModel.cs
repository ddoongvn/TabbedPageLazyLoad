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
    public class TestPopupViewModel : ViewModelBase
    {
        public TestPopupViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {
            CloseCommand = new DelegateCommand(Close);
        }

        public ICommand CloseCommand { get; }
        private void Close()
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}
