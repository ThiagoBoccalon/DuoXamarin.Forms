using AppDuoXF.Interfaces;
using AppDuoXF.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppDuoXF.Fakes
{
    public class LessonServiceFake : ILessonService
    {
        private string _colorLevel5 = "#f7c745";
        private string _colorLevel4 = "#f19a37";
        private string _colorLevel3 = "#ec5954";
        private string _colorLevel2 = "#8bc63b";
        private string _colorLevel1 = "#4faef0";        
        private string _colorBonus  = "#ffffff";
        public async Task<List<LessonGroup>> GetLessonsGroup()
        {
            return await Task.Run(() =>
            {
                return new List<LessonGroup>
                    {
                        new LessonGroup
                        {
                            Type = Enums.LessonGroupTypeEnum.Single,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Introduction", "4", "lesson_egg", _colorLevel5)
                            }
                        },

                        new LessonGroup
                        {
                            Type = Enums.LessonGroupTypeEnum.Multi,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Greetings", "4", "lesson_dialog", _colorLevel4),
                                GetNewLesson("Travel", string.Empty, "lesson_airplane", _colorLevel3)
                            }
                        },

                        new LessonGroup
                        {
                            Type = Enums.LessonGroupTypeEnum.Multi,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Food", string.Empty, "lesson_hamburger", _colorLevel2),
                                GetNewLesson("Family", string.Empty, "lesson_baby", _colorLevel1),
                            }
                        },

                        new LessonGroup
                        {
                            Type = Enums.LessonGroupTypeEnum.Bonus,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Bonus", string.Empty, "lesson_plus", _colorBonus),
                                GetNewLesson("Bonus", string.Empty, "lesson_plus", _colorBonus),
                                GetNewLesson("Bonus", string.Empty, "lesson_plus", _colorBonus)
                            }
                        }
                    };

                });
        }

        private Lesson GetNewLesson(string name, string level, string icon, string color)
        {
            return new Lesson
            {
                Name = name,
                Level = level,
                Icon = icon,
                Color = color
            };
        }
    }
}
