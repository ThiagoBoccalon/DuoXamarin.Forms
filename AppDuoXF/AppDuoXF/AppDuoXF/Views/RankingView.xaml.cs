using AppDuoXF.Interfaces;
using Xamarin.Forms;

namespace AppDuoXF.Views
{
    public partial class RankingView : ContentPage, ITabPageIcons
    {
        public RankingView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return "tab_ranking";
        }

        public string GetSelectedIcon()
        {
            return "tab_ranking_selected";
        }
    }
}
