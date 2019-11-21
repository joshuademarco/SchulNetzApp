﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SchulNetzApp.Droid.Code;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]
namespace SchulNetzApp.Droid.Code
{
    class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Red);
            else
                Control.Background.SetColorFilter(Android.Graphics.Color.Red, PorterDuff.Mode.SrcAtop);
        }
    }
}