
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

            Children.Add(new RankingView());            
            Children.Add(new ProfileView());            
            Children.Add(new StoreView());
        }
    }
}
