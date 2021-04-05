using AppDuoXF.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDuoXF.Models
{
    public class LessonGroup
    {
        public LessonGroupTypeEnum Type { get; set; }
        public IList<Lesson> Lessons { get; set; }

        public LessonGroup()
        {
            Lessons = new List<Lesson>();
        }
    }
}
