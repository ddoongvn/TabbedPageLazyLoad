using Prism.Navigation;
using Xamarin.Forms;

namespace TabbedPageLazyLoad.Views
{
    public partial class Home : ContentView,INavigationAware
    {
        public Home()
        {
            InitializeComponent();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new System.NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //throw new System.NotImplementedException();
        }
    }
}
