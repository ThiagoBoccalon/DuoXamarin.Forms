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
                                GetNewLesson("Introduction", "4")
                            }
                        },

                        new LessonGroup
                        {
                            Type = Enums.LessonGroupTypeEnum.Multi,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Greetings", "4"),
                                GetNewLesson("Travel", string.Empty)
                            }
                        },

                        new LessonGroup
                        {
                            Type = Enums.LessonGroupTypeEnum.Bonus,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Bonus", string.Empty),
                                GetNewLesson("Bonus", string.Empty),
                                GetNewLesson("Bonus", string.Empty)
                            }
                        }
                    };

                });
        }

        private Lesson GetNewLesson(string name, string level)
        {
            return new Lesson
            {
                Name = name,
                Level = level
            };
        }
    }
}
