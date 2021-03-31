using AppDuoXF.Interfaces;
using AppDuoXF.Views.TitleViews;
using Xamarin.Forms;

namespace AppDuoXF.Views
{
    public partial class StoreView : ContentPage, IDynamicTitle
    {
        private View _title;
        public StoreView()
        {
            InitializeComponent();
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new StoreTitleView();

            return _title;
        }
    }
}
