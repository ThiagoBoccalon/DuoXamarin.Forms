using AppDuoXF.Interfaces;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppDuoXF.ViewModels
{
    public class StoriesViewModel : BindableBase, IActiveAware
    {
        private readonly IStoriesService _storiesService;
        public StoriesViewModel(IStoriesService storiesService)
        {
            storiesService = _storiesService;
        }

        private bool _isActive;
        public bool IsActive 
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged);
        }

        public event EventHandler IsActiveChanged;

        private void RaiseIsActivatedChanged()
        {
            if (IsActive)
            {
                System.Diagnostics.Debug.WriteLine("Evento da aba");
            }
        }
    }
}
