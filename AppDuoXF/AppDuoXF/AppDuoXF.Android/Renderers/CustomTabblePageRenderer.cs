using Android.Content;
using AppDuoXF.Droid.Renderers;
using Google.Android.Material.BottomNavigation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabblePageRenderer))]
namespace AppDuoXF.Droid.Renderers
{
    public class CustomTabblePageRenderer : TabbedPageRenderer
    {
        public CustomTabblePageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);
            
            if(e.NewElement != null)
            {
                var relativeLayout = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                var bottomNavigationView = relativeLayout.GetChildAt(1) as BottomNavigationView;
                bottomNavigationView.SetMinimumHeight(300);
            }
            
        }
    }
}