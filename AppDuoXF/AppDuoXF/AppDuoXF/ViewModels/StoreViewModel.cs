using AppDuoXF.Interfaces;
using AppDuoXF.Models;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppDuoXF.ViewModels
{
    public class StoreViewModel : BindableBase, IActiveAware
    {
        private readonly IStoreService _storeService;
        
        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaisePropertyChanged);
        }

        public event EventHandler IsActiveChanged;
        public List<StoreItemGroup> Groups { get; private set; }

        public StoreViewModel(IStoreService storeService)
        {
            _storeService = storeService;
            Groups = new List<StoreItemGroup>();
        }

        private async void RaisePropertyChanged()
        {
            if (IsActive)
            {
                if (!Groups.Any())
                {
                    var storeGroups = await _storeService.GetItems();
                    Groups.AddRange(storeGroups);
                }
            }
        }
    }
}
