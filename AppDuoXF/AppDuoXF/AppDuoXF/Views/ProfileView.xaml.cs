﻿using AppDuoXF.Interfaces;
using AppDuoXF.Views.TitleViews;
using Xamarin.Forms;

namespace AppDuoXF.Views
{
    public partial class ProfileView : ContentPage, IDynamicTitle
    {
        private View _title;
        public ProfileView()
        {
            InitializeComponent();
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new ProfileTitleView();

            return _title;
        }
    }
}
