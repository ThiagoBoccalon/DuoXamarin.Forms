﻿using AppDuoXF.ContentViews;
using AppDuoXF.Interfaces;
using AppDuoXF.Views.TitleViews;
using System;
using Xamarin.Forms;

namespace AppDuoXF.Views
{
    public partial class ProfileView : ContentPage, IDynamicTitle, ITabPageIcons
    {
        private View _title;
        private Lazy<ProfileAchievementsContentView> _sectionAchievements = new Lazy<ProfileAchievementsContentView>();
        private Lazy<ProfileFriendsContentView> _sectionFriends = new Lazy<ProfileFriendsContentView>();

        public ProfileView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var index = 0;
            foreach(var view in flexLayoutSection.Children)
            {
                if(view is Grid grid)
                {
                    if(index++ == 0)
                    {
                        GoToStateSelected(grid);
                        sectionContentView.Content = _sectionAchievements.Value;
                        continue;
                    }

                    GoToStateSelected(grid);
                }
            }
        }

        private Grid _lastSelected;

        private void OnTappedSection(object sender, EventArgs args)
        {
            if(sender is Grid grid)
            {
                GoToStateUnSelected(_lastSelected);
                GoToStateSelected(grid);

                if(grid.AutomationId == "gridAchievements")
                {
                    sectionContentView.Content = _sectionAchievements.Value;
                    return;
                }

                if (grid.AutomationId == "gridFriends")
                {
                    sectionContentView.Content = _sectionFriends.Value;
                    return;
                }
            }
        }

        private void GoToStateSelected(Grid grid)
        {
            _lastSelected = grid;

            if(grid.Children[0] is Label label &&
                grid.Children[1] is BoxView boxView)
            {
                VisualStateManager.GoToState(label, "Selected");
                VisualStateManager.GoToState(boxView, "Selected");
            }
        }

        private void GoToStateUnSelected(Grid grid)
        {
            if(grid.Children[0] is Label label &&
                grid.Children[1] is BoxView boxView)
            {
                VisualStateManager.GoToState(label, "UnSelected");
                VisualStateManager.GoToState(boxView, "UnSelected");
            }
        }

        public string GetIcon()
        {
            return "tab_profile";
        }

        public string GetSelectedIcon()
        {
            return "tab_profile_selected";
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new ProfileTitleView();

            return _title;
        }
    }
}
