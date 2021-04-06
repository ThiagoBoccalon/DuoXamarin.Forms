using AppDuoXF.ContentViews;
using AppDuoXF.Enums;
using AppDuoXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppDuoXF.Templates
{
    public class LessonGroupDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Single { get; set; }
        public DataTemplate Multi { get; set; }
        public DataTemplate Bonus { get; set; }

        public LessonGroupDataTemplateSelector()
        {
            Single = new DataTemplate(typeof(LessonGroupSingleContentView));
            Multi = new DataTemplate(typeof(LessonGroupMultiContentView));
            Bonus = new DataTemplate(typeof(LessonGroupBonusContentView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is LessonGroup group)
            {
                if (group.Type == LessonGroupTypeEnum.Multi)
                    return Multi;

                if (group.Type == LessonGroupTypeEnum.Bonus)
                    return Bonus;
            }

            return Single;            
        }
    }
}
