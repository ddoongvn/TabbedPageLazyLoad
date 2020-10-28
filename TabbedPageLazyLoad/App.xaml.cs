using Prism;
using Prism.Ioc;
using TabbedPageLazyLoad.ViewModels;
using TabbedPageLazyLoad.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;

namespace TabbedPageLazyLoad
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<TabbedPageLazy, TabbedPageLazyViewModel>();

            containerRegistry.Register<ContentView, Home>(PageEnum.Home.ToString());
            containerRegistry.Register<ContentView, Account>(PageEnum.Account.ToString());
            containerRegistry.Register<ContentView, Online>(PageEnum.Online.ToString());
            containerRegistry.Register<ContentView, Vehicle>(PageEnum.Vehicle.ToString());

            //containerRegistry.RegisterForNavigation<Home, HomeViewModel>();
            //containerRegistry.RegisterForNavigation<Online, OnlineViewModel>();
            //containerRegistry.RegisterForNavigation<Account, AccountViewModel>();
            //containerRegistry.RegisterForNavigation<Vehicle, VehicleViewModel>();
            containerRegistry.RegisterForNavigation<TestPopup, TestPopupViewModel>();
        }
    }
}
