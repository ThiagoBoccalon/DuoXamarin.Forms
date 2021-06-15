using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppDuoXF.Converters
{
    class AchievementsActiveToTextColorConverter : IValueConverter
    {
        private Color _activeColor = Color.White;
        private Color _finishColor = Color.FromHex("#cc7700");
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool isActive)
            {
                if (isActive)
                    return _activeColor;

                return _finishColor;
            }

            return _activeColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
