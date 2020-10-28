using System;
using Prism.Behaviors;
using Prism.Common;
using Prism.Navigation;
using Xamarin.Forms;

namespace TabbedPageLazyLoad.Behavior
{
    public class TabbedPageNavigationBehavior : BehaviorBase<TabbedPage>
    {
        private ContentPage CurrentPage;

        protected override void OnAttachedTo(TabbedPage bindable)
        {
            bindable.CurrentPageChanged += this.OnCurrentPageChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(TabbedPage bindable)
        {
            bindable.CurrentPageChanged -= this.OnCurrentPageChanged;
            base.OnDetachingFrom(bindable);
        }

        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            var newPage = (ContentPage)this.AssociatedObject.CurrentPage;

            if (this.CurrentPage != null)
            {
                var parameters = new NavigationParameters();
                PageUtilities.OnNavigatedFrom(this.CurrentPage.Content, parameters);
                PageUtilities.OnNavigatedTo(newPage.Content, parameters);
            }

            this.CurrentPage = newPage;
        }
    }
}
