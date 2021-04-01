using AppDuoXF.Interfaces;
using Xamarin.Forms;

namespace AppDuoXF.Views
{
    public partial class TrainingView : ContentPage, ITabPageIcons
    {
        public TrainingView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return "tab_training";
        }

        public string GetSelectedIcon()
        {
            return "tab_training_selected";
        }
    }
}
