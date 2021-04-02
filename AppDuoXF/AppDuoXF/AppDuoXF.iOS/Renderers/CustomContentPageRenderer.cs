using AppDuoXF.iOS.Renderers;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ContentPage), typeof(CustomContentPageRenderer))]
namespace AppDuoXF.iOS.Renderers
{
    public class CustomContentPageRenderer : PageRenderer
    {
        public override bool PrefersStatusBarHidden()
        {
            return true;
        }

    }
}