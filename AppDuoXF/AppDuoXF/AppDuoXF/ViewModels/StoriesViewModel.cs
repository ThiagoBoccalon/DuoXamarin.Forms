using AppDuoXF.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppDuoXF.ViewModels
{
    public class StoriesViewModel : BindableBase
    {
        private readonly IStoriesService _storiesService;
        public StoriesViewModel(IStoriesService storiesService)
        {
            storiesService = _storiesService;
        }
    }
}
