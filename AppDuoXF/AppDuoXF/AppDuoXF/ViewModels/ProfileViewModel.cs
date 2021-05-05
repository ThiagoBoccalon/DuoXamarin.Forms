using AppDuoXF.Interfaces;
using AppDuoXF.Models;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace AppDuoXF.ViewModels
{
    public class ProfileViewModel : BindableBase, IActiveAware
    {
        private readonly IAchievementsService _achievementsService;

        public ObservableCollection<Achievement> Achievements { get; private set; }

        public ProfileViewModel(IAchievementsService  achievementsService)
        {
            _achievementsService = achievementsService;
            Achievements = new ObservableCollection<Achievement>();
        }

        public event EventHandler IsActiveChanged;

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged);
        }

        private async void RaiseIsActivatedChanged()
        {
            await RaiseIsActivatedChangedAsync();
        }

        private async Task RaiseIsActivatedChangedAsync()
        {
            if (IsActive)
            {
                if(Achievements.Count == 0)
                {
                    var achievements = await _achievementsService.GetAchievementsAsync();

                    foreach (var achievement in achievements)
                        Achievements.Add(achievement);
                }
            }
        }
    }
}
