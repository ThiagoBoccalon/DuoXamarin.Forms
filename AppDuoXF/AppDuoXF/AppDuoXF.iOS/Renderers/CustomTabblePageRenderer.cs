using AppDuoXF.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabblePageRenderer))]
namespace AppDuoXF.iOS.Renderers
{
    public class CustomTabblePageRenderer : TabbedRenderer
    {      
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
                        
            var tabFrame = TabBar.Frame;

            var tabHeight = 150;
            tabFrame.Height = tabHeight;
            tabFrame.Y = View.Frame.Height - tabHeight;

            TabBar.Frame = tabFrame;
        }
    }
}