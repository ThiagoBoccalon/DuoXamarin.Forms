using AppDuoXF.iOS.Renderers;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ImageButton), typeof(CustomImageButtonRenderer))]
namespace AppDuoXF.iOS.Renderers
{
    public class CustomImageButtonRenderer : ImageButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ImageButton> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
                Control.AdjustsImageWhenHighlighted = false;
        }

        protected override UIButton CreateNativeControl()
        {
            return new UIButton(UIButtonType.Custom);
        }
    }
}