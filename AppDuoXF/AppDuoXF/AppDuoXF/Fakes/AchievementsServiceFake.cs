using AppDuoXF.Interfaces;
using AppDuoXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppDuoXF.Fakes
{
    public class AchievementsServiceFake : IAchievementsService
    {
        public async Task<IList<Achievement>> GetAchievementsAsync()
        {
            return await Task.Run(() =>
            {
                return new List<Achievement>
                {
                    GetAchievement(
                    "profile_achievements_01",
                    "LEVEL 9",
                    "Majestade",
                    "Earn 80 crowns",
                    0.9875,
                    "79/80",
                    true),

                    GetAchievement(
                    "profile_achievements_02",
                    "LEVEL 8",
                    "Intellectual",
                    "Learn 1,000 new words in one course",
                    0.863,
                    "863/1k",
                    true),

                    GetAchievement(
                    "profile_achievements_03",
                    "LEVEL 5",
                    "Bull's eye",
                    "Complete 100 lessons without makink a mistake",
                    0.81,
                    "81/100",
                    true),

                    GetAchievement(
                    "profile_achievements_04",
                    "LEVEL 7",
                    "Knows all",
                    "Earn 7500 XP",
                    0.72,
                    "5,4K/7,5K",
                    true),

                    GetAchievement(
                    "profile_achievements_05",
                    "LEVEL 3",
                    "Bonfire",
                    "Reach a 14-day offensive",
                    0.5,
                    "7/14",
                    true),

                    GetAchievement(
                    "profile_achievements_06",
                    "LEVEL 1",
                    "Strategist",
                    "You read a tip",
                    1,
                    string.Empty,
                    false),
                };
            });
        }

        private Achievement GetAchievement(
            string icon,
            string level,
            string name,
            string description,
            double progress, 
            string status,
            bool isActive)
        {
            return new Achievement
            {
                Icon = icon,
                Level = level,
                Name = name,
                Description = description,
                Progress = progress,
                Status = status,
                IsActive = isActive
            };
        }
    }
}
