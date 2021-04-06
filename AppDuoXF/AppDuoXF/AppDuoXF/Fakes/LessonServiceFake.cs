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
                                GetNewLesson("Introduction")
                            }
                        },

                        new LessonGroup
                        {
                            Type = Enums.LessonGroupTypeEnum.Multi,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Greetings"),
                                GetNewLesson("Travel")
                            }
                        },

                        new LessonGroup
                        {
                            Type = Enums.LessonGroupTypeEnum.Bonus,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Bonus"),
                                GetNewLesson("Bonus"),
                                GetNewLesson("Bonus")
                            }
                        }
                    };

                });
        }

        private Lesson GetNewLesson(string name)
        {
            return new Lesson
            {
                Name = name
            };
        }
    }
}
