using Prism;
using Prism.Common;
using Prism.Events;
using Prism.Ioc;
using Prism.Navigation;
using Syncfusion.XForms.TabView;
using System;
using System.Collections.Generic;
using System.Linq;
using TabbedPageLazyLoad.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using TabbedPage = Xamarin.Forms.TabbedPage;

namespace TabbedPageLazyLoad.Views
{
    public partial class TabbedPageLazy : TabbedPage
    {
     
        private readonly IEventAggregator eventAggregator;
        private IList<PageEnum> pages { get; set; } = new List<PageEnum>();
        public TabbedPageLazy()
        {
            try
            {
                eventAggregator = PrismApplicationBase.Current.Container.Resolve<IEventAggregator>();
                
                InitializeComponent();
                On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
                this.On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);

                pages.Add(PageEnum.Home);
                var home = new ContentPage() { IconImageSource = "home", Title = "Home" };
                Children.Add(home);

                pages.Add(PageEnum.Vehicle);
                var vehicle = new ContentPage() { IconImageSource = "vehicle", Title = "Vehicle" };              
               
                Children.Add(vehicle);


                pages.Add(PageEnum.Online);
                var online = new ContentPage() { IconImageSource = "ic_Mornitoring.png", Title = "Online" };
                Children.Add(online);

                pages.Add(PageEnum.Account);
                var account = new ContentPage() { IconImageSource = "account", Title = "Account" };
                //var viewResolve = PrismApplicationBase.Current.Container.Resolve<ContentView>(PageEnum.Account.ToString());
                //account.Content = viewResolve;
                Children.Add(account);

                if (true)
                {
                    CurrentPage = account;
                }

            }
            catch (System.Exception ex)
            {

            }
        }

       
        bool firstChange { get; set; }
        private void root_CurrentPageChanged(object sender, EventArgs e)
        {
            var currenView = ((TabbedPageLazyViewModel)BindingContext).currentView;
            try
            {
                if (firstChange)
                {
                    var newPage = (ContentPage)CurrentPage;
                    var parameters = new NavigationParameters();
                    if (newPage.Content == null)
                    {
                        var currentIndex = GetIndex(CurrentPage);
                        var pageEnum = pages[currentIndex];
                        var viewResolve = PrismApplicationBase.Current.Container.Resolve<ContentView>(pageEnum.ToString());
                        newPage.Content = viewResolve;                      
                    }
                    if (currenView != null)
                    {                      
                        PageUtilities.OnNavigatedFrom(currenView, parameters);                       
                    }

                    PageUtilities.OnNavigatedTo(newPage.Content, parameters);
                    ((TabbedPageLazyViewModel)BindingContext).currentView = newPage.Content;
                }
                else
                {
                    firstChange = true;
                }
            }
            catch (Exception ex)
            {


            }
        }

       
    }
    public enum PageEnum
    {
        Home,
        Vehicle,
        Online,
        Account
    }
    public class SleepEvent : PubSubEvent
    {

    }

    public class ResumeEvent : PubSubEvent
    {

    }

}
