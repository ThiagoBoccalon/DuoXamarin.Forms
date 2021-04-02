﻿using Android.Content;
using Xamarin.Forms.Platform.Android;
using AppDuoXF.Controls;
using Google.Android.Material.FloatingActionButton;
using Xamarin.Forms;
using AppDuoXF.Droid.Renderers;
using System;
using Android.Content.Res;

[assembly : ExportRenderer(typeof(FormsFloatingAcctionButton), typeof(FormsFloatingAcctionButtonRenderer))]
namespace AppDuoXF.Droid.Renderers
{
    public class FormsFloatingAcctionButtonRenderer : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<FormsFloatingAcctionButton, FloatingActionButton>
    {
        private FloatingActionButton _floatingActionButton;
        public FormsFloatingAcctionButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<FormsFloatingAcctionButton> e)
        {
            base.OnElementChanged(e);

            if(e.NewElement != null)
            {
                _floatingActionButton = new FloatingActionButton(Context);
                _floatingActionButton.UseCompatPadding = true;
                ConfigureBackgroundColor();
                _floatingActionButton.Click += OnFabClick;
                SetNativeControl(_floatingActionButton);
            }

        }

        private void ConfigureBackgroundColor()
        {
            if (Element == null)
                return;

            var floatingActionButtonColor = Element.BackgroundColor.ToAndroid();
            _floatingActionButton.BackgroundTintList = ColorStateList.ValueOf(floatingActionButtonColor);
            Element.BackgroundColor = Color.Transparent;
        }

        private void OnFabClick(object sender, EventArgs e)
        {
            Element?.Command?.Execute(null);
        }
    }
}