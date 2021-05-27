﻿using AppDuoXF.Controls;
using AppDuoXF.iOS.Controls;
using AppDuoXF.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HorizontalProgressBar), typeof(HorizontalProgressBarRenderer))]
namespace AppDuoXF.iOS.Renderers
{
    public class HorizontalProgressBarRenderer : ViewRenderer<HorizontalProgressBar, HorizontalProgressBariOS>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HorizontalProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control is null)
            {
                if (Element is null)
                    return;

                var nativeControl = new HorizontalProgressBariOS(
                    Element.WidthRequest,
                    Element.HeightRequest,
                    Element.TrackColor.ToCGColor(),
                    Element.ProgressColor.ToCGColor(),
                    Element.Progress
                );

                SetNativeControl(nativeControl);
            }
        }
    }
}