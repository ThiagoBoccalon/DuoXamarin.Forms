using AppDuoXF.Controls;
using AppDuoXF.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircularProgressBar), typeof(CircularProgressBarRenderer))]
namespace AppDuoXF.iOS.Renderers
{
    class CircularProgressBarRenderer : ViewRenderer<CircularProgressBar, UIView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CircularProgressBar> e)
        {
            base.OnElementChanged(e);
        }
    }
}