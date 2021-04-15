using AppDuoXF.Controls;
using AppDuoXF.iOS.Controls;
using AppDuoXF.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircularProgressBar), typeof(CircularProgressBarRenderer))]
namespace AppDuoXF.iOS.Renderers
{
    class CircularProgressBarRenderer : ViewRenderer<CircularProgressBar, CircularProgressBariOS>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CircularProgressBar> e)
        {
            base.OnElementChanged(e);
            if(Control is null)
            {
                if (Element is null)
                    return;

                var nativeControl = new CircularProgressBariOS(
                    Element.WidthRequest,
                    Element.HeightRequest
                    );

                SetNativeControl(nativeControl);
            }
        }
    }
}