using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppDuoXF.Controls
{
    public class ProgressBarBase : View
    {
        public static readonly BindableProperty TrackColorProperty =
            BindableProperty.Create(
                nameof(TrackColor),
                typeof(Color),
                typeof(ProgressBar),
                Color.Transparent
                );

        public Color TrackColor
        {
            get => (Color)GetValue(TrackColorProperty);
            set => SetValue(TrackColorProperty, value);
        }

        public static readonly BindableProperty ProgressColorProperty =
            BindableProperty.Create(
                nameof(ProgressColor),
                typeof(Color),
                typeof(ProgressBar),
                Color.Transparent
            );

        public Color ProgressColor
        {
            get => (Color)GetValue(ProgressColorProperty);
            set => SetValue(ProgressColorProperty, value);
        }

        public static readonly BindableProperty ProgressProperty =
           BindableProperty.Create(
               nameof(Progress),
               typeof(double),
               typeof(ProgressBar),
               0.0
           );

        public double Progress
        {
            get => (double)GetValue(ProgressProperty);
            set => SetValue(ProgressProperty, value);
        }
    }
}
