using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace TabbedPageLazyLoad.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {
            Title = "Main Page";
            GotoCommand = new DelegateCommand(Goto);
            GoBackCommand = new DelegateCommand(GoBack);
        }

        public ICommand GotoCommand { get; }
        public ICommand GoBackCommand { get; }
        private void Goto()
        {
            NavigationService.NavigateAsync("TabbedPageLazy");
        }
        private void GoBack()
        {
            NavigationService.GoBackAsync();
        }
    }
}
