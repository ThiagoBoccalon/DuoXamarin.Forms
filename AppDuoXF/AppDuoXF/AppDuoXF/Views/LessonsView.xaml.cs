using AppDuoXF.Interfaces;
using AppDuoXF.Views.TitleViews;
using Xamarin.Forms;

namespace AppDuoXF.Views
{
    public partial class LessonsView : ContentPage, IDynamicTitle
    {
        private View _title;
        public LessonsView()
        {
            InitializeComponent();
        }

        public View GetTitle()
        {
            if(_title == null)
                _title = new LessonsTitleView();
            
            return _title;
        }
    }
}
