using AppDuoXF.Interfaces;
using AppDuoXF.Views.TitleViews;
using Xamarin.Forms;

namespace AppDuoXF.Views
{
    public partial class StoriesView : ContentPage, IDynamicTitle, ITabPageIcons
    {
        private View _titles;

        public StoriesView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return "tab_stories";
        }

        public string GetSelectedIcon()
        {
            return "tab_stories_selected";
        }

        public View GetTitle()
        {
            if (_titles == null)
                _titles = new StoriesTitleView();

            return _titles;
                
        }
    }
}
