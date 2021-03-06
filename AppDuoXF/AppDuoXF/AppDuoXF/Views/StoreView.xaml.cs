using AppDuoXF.Interfaces;
using AppDuoXF.Views.TitleViews;
using Xamarin.Forms;

namespace AppDuoXF.Views
{
    public partial class StoreView : ContentPage, IDynamicTitle, ITabPageIcons
    {
        private View _title;
        public StoreView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return "tab_store";
        }

        public string GetSelectedIcon()
        {
            return "tab_store_selected";
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new StoreTitleView();

            return _title;
        }
    }
}
