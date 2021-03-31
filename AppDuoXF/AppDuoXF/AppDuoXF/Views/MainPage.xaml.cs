
using AppDuoXF.Interfaces;
using System;
using Xamarin.Forms;

namespace AppDuoXF.Views
{
    public partial class MainPage
    {        
        public MainPage()
        {
            InitializeComponent();

            Children.Add(new LessonsView());
            
            if(Device.RuntimePlatform == Device.iOS)
                Children.Add(new TrainingView());

            Children.Add(new ProfileView());
            Children.Add(new RankingView());
            Children.Add(new StoreView());
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            if(CurrentPage is IDynamicTitle page)
            {
                NavigationPage.SetHasNavigationBar(this, true);
                NavigationPage.SetTitleView(this, page.GetTitle());
                return;
            }

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
