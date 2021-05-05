using AppDuoXF.Fakes;
using AppDuoXF.Interfaces;
using AppDuoXF.ViewModels;
using AppDuoXF.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace AppDuoXF
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            var mainPage = $"{nameof(NavigationPage)}/{nameof(MainPage)}";
            await NavigationService.NavigateAsync(mainPage);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<LessonsView, LessonsViewModel>();
            containerRegistry.RegisterForNavigation<StoriesView, StoriesViewModel>();
            containerRegistry.RegisterForNavigation<TrainingView, TrainingViewModel>();
            containerRegistry.RegisterForNavigation<ProfileView, ProfileViewModel>();
            containerRegistry.RegisterForNavigation<RankingView, RankingViewModel>();
            containerRegistry.RegisterForNavigation<StoreView, StoreViewModel>();
            

            containerRegistry.Register<ILessonService, LessonServiceFake>();
            containerRegistry.Register<IStoriesService, StoriesServiceFake>();
            containerRegistry.Register<IAchievementsService, AchievementsServiceFake>();
        }
    }
}
