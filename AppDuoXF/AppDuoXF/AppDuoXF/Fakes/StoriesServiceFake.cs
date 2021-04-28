using AppDuoXF.Interfaces;
using AppDuoXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppDuoXF.Fakes
{
    public class StoriesServiceFake : IStoriesService
    {
        public async Task<IList<Stories>> GetStories()
        {
            return await Task.Run(() =>
            {
                return new List<Stories>()
                {
                    GetNewStories("Bom dia!", "stories_coffe"),
                    GetNewStories("Um encontro", "stories_candle"),
                    GetNewStories("Uma coisa", "stories_bread"),
                    GetNewStories("Surpresa", "stories_gift")
                };
            });
        }

        private Stories GetNewStories(string name, string image)
        {
            return new Stories
            {
                Name = name,
                Image = image
            };
        }
    }
}
