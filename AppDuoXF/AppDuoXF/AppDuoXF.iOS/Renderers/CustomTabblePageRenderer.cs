using AppDuoXF.Interfaces;
using AppDuoXF.iOS.Renderers;
using AppDuoXF.Views;
using System;
using System.Threading.Tasks;
using UIKit;
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

        protected override async Task<System.Tuple<UIImage, UIImage>> GetIcon(Page page)
        {
            if (page is ITabPageIcons tabPage)
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile(tabPage.GetIcon()),
                        GetImageFromFile(tabPage.GetSelectedIcon()))
                );


            return await base.GetIcon(page);
        }

        private UIImage GetImageFromFile(string fileName)
        {
            return UIImage.FromFile(fileName)
                   .ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
        }

    }
}