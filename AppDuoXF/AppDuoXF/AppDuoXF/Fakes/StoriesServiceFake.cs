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
        public async Task<IList<StoriesGroup>> GetStories()
        {
            return await Task.Run(() =>
            {
                return new List<StoriesGroup>()
                {
                    new StoriesGroup(
                        "Level 1",
                        new List<Stories>()
                        {
                            GetNewStories("Good Morning!", "stories_coffe"),
                            GetNewStories("A Date", "stories_candle"),
                            GetNewStories("One Thing", "stories_bread"),
                            GetNewStories("Surprise", "stories_gift")
                        }
                    )                    
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
