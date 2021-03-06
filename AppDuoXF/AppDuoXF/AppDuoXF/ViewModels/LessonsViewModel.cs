using AppDuoXF.Interfaces;
using AppDuoXF.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppDuoXF.ViewModels
{
    public class LessonsViewModel : BindableBase, IInitialize
    {
        private readonly ILessonService _lessonService;
        public ICommand NavigateToTrainingCommand { get; private set; }
        public ObservableCollection<LessonGroup> LessonGroup { get; private set; }

        public LessonsViewModel(ILessonService lessonService)
        {
            _lessonService = lessonService;
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
            LessonGroup = new ObservableCollection<LessonGroup>();
        }
        
        private void NavigateToTrainingExecute()
        {
            System.Diagnostics.Debug.WriteLine("The button FAB was clicked.");
        }

        public async void Initialize(INavigationParameters parameters)
        {
            var groups = await GetLessonsGroup();

            foreach (var group in groups)
                LessonGroup.Add(group);
        }

        private async Task<IList<LessonGroup>> GetLessonsGroup()
        {
            return await _lessonService.GetLessonsGroup();
        }
    }
}
