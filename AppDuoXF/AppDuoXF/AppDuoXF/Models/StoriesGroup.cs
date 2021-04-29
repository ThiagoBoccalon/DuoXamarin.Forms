using System;
using System.Collections.Generic;
using System.Text;

namespace AppDuoXF.Models
{
    public class StoriesGroup : List<Stories>
    {
        public string Name { get; private set; }

        public StoriesGroup(string name, List<Stories> stories) : base(stories)
        {
            Name = name;
        }
    }
}
