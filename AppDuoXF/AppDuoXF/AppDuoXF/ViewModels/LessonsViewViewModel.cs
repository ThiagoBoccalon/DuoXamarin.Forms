using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace AppDuoXF.ViewModels
{
    public class LessonsViewViewModel : BindableBase
    {
        public ICommand NavigateToTrainingCommand { get; private set; }

        public LessonsViewViewModel()
        {
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
        }

        private void NavigateToTrainingExecute()
        {
            System.Diagnostics.Debug.WriteLine("The button FAB was clicked.");
        }
    }
}
