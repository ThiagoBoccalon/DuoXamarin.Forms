using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppDuoXF.Controls;
using AppDuoXF.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(CircularProgressBar), typeof(CircularProgressBarRenderer))]
namespace AppDuoXF.Droid.Renderers
{
    public class CircularProgressBarRenderer : ViewRenderer<CircularProgressBar, Android.Widget.ProgressBar>
    {
        public CircularProgressBarRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CircularProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control is null)
            {
                var nativeControl = new Android.Widget.ProgressBar(
                    Context,
                    null,
                    Android.Resource.Attribute.ProgressBarStyleHorizontal
                );

                nativeControl.SetBackground(Context.GetDrawable(Resource.Drawable.circular_track_bar));
                nativeControl.ProgressDrawable = Context.GetDrawable(Resource.Drawable.circular_progress_bar);
                nativeControl.Max = 100;
                nativeControl.Progress = 20;

                SetNativeControl(nativeControl);
            }
        }
    }
}