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
                            GetNewStories("Good Morning!", "stories_coffe", "#f5b43f"),
                            GetNewStories("A Date", "stories_candle", "#503322"),
                            GetNewStories("One Thing", "stories_bread", "#68ad33"),
                            GetNewStories("Surprise", "stories_gift", "#de90d0")
                        }
                    )                    
                };
            });
        }

        private Stories GetNewStories(string name, string image, string shadowBottomColor)
        {
            return new Stories
            {
                Name = name,
                Image = image,
                ShadowBottomColor = shadowBottomColor
            };
        }
    }
}
