using Android.Content;
using Xamarin.Forms.Platform.Android;
using AppDuoXF.Controls;
using Google.Android.Material.FloatingActionButton;
using Xamarin.Forms;
using AppDuoXF.Droid.Renderers;
using System;

[assembly : ExportRenderer(typeof(FormsFloatingAcctionButton), typeof(FormsFloatingAcctionButtonRenderer))]
namespace AppDuoXF.Droid.Renderers
{
    public class FormsFloatingAcctionButtonRenderer : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<FormsFloatingAcctionButton, FloatingActionButton>
    {
        public FormsFloatingAcctionButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<FormsFloatingAcctionButton> e)
        {
            base.OnElementChanged(e);

            if(e.NewElement != null)
            {
                var fab = new FloatingActionButton(Context);
                fab.UseCompatPadding = true;
                fab.Click += OnFabClick;
                SetNativeControl(fab);
            }

        }

        private void OnFabClick(object sender, EventArgs e)
        {
            Element?.Command?.Execute(null);
        }
    }
}