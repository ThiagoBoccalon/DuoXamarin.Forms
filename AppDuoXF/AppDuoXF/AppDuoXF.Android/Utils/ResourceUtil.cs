using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDuoXF.Droid.Utils
{
    public class ResourceUtil
    {
        public static int GetDrawableIdByFileName(string fileName, Context context)
        {            
            return context.Resources.GetIdentifier(fileName,  "drawable", context.PackageName);
        }
    }
}