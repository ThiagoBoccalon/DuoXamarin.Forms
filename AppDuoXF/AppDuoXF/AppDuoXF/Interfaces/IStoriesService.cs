using AppDuoXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppDuoXF.Interfaces
{
    public interface IStoriesService
    {
        Task<IList<StoriesGroup>> GetStories();
    }
}
