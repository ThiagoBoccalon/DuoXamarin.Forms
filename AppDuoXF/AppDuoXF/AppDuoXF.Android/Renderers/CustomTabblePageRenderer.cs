using Android.Content;
using AppDuoXF.Droid.Renderers;
using AppDuoXF.Droid.Utils;
using AppDuoXF.Interfaces;
using Google.Android.Material.BottomNavigation;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabblePageRenderer))]
namespace AppDuoXF.Droid.Renderers
{
    public class CustomTabblePageRenderer : TabbedPageRenderer
    {
        private TabbedPage _formsTabs;
        private BottomNavigationView _bottomNavigationView;

        public CustomTabblePageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                _formsTabs = Element;
                _formsTabs.CurrentPageChanged += OnCurrentPageChanged;

                var relativeLayout = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                _bottomNavigationView = relativeLayout.GetChildAt(1) as BottomNavigationView;
                _bottomNavigationView.SetMinimumHeight(300);
                _bottomNavigationView.ItemIconTintList = null;
                _bottomNavigationView.ItemIconSize = 150;
                _bottomNavigationView.SetShiftMode(false, false);
                _bottomNavigationView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;

                UpdateAlltabs();
            }

            if (e.OldElement != null)
                _formsTabs.CurrentPageChanged -= OnCurrentPageChanged;
        }

        private void UpdateAlltabs()
        {
            for (var index = 0; index < _formsTabs.Children.Count; index++)
            {
                var androidTab = _bottomNavigationView.Menu.GetItem(index);
                int iconId;
                
                if(_formsTabs.Children[index] is ITabPageIcons tabPage)
                {
                    if(_formsTabs.Children[index] == _formsTabs.CurrentPage)
                    {
                        iconId = ResourceUtil.GetDrawableIdByFileName(tabPage.GetSelectedIcon(), Context);
                        androidTab.SetIcon(iconId);
                        continue;
                    }

                    iconId = ResourceUtil.GetDrawableIdByFileName(tabPage.GetIcon(), Context);
                    androidTab.SetIcon(iconId);
                }
            }
        }

        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            UpdateAlltabs();
        }
    }
}