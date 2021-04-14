using AppDuoXF.Interfaces;
using AppDuoXF.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppDuoXF.Fakes
{
    public class LessonServiceFake : ILessonService
    {
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
                                GetNewLesson("Introduction", "4", "lesson_egg", "#f19a37")
                            }
                        },

                        new LessonGroup
                        {
                            Type = Enums.LessonGroupTypeEnum.Multi,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Greetings", "4", "lesson_dialog", "#f19a37"),
                                GetNewLesson("Travel", string.Empty, "lesson_airplane", "#c287f8")
                            }
                        },

                        new LessonGroup
                        {
                            Type = Enums.LessonGroupTypeEnum.Multi,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Food", string.Empty, "lesson_hamburger", "#c287f8"),
                                GetNewLesson("Family", string.Empty, "lesson_baby", "#c287f8"),
                            }
                        },

                        new LessonGroup
                        {
                            Type = Enums.LessonGroupTypeEnum.Bonus,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Bonus", string.Empty, "lesson_plus", "#ffffff"),
                                GetNewLesson("Bonus", string.Empty, "lesson_plus", "#ffffff"),
                                GetNewLesson("Bonus", string.Empty, "lesson_plus", "#ffffff")
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
