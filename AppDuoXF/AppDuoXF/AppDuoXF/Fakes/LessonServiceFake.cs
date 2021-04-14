using AppDuoXF.Interfaces;
using AppDuoXF.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppDuoXF.Enums;

namespace AppDuoXF.Fakes
{
    public class LessonServiceFake : ILessonService
    {
        private string _colorLevel5 = "#f7c745";
        private string _colorLevel4 = "#f19a37";
        private string _colorLevel3 = "#ec5954";
        private string _colorLevel2 = "#8bc63b";
        private string _colorLevel1 = "#4faef0";
        private string _colorLevel0 = "#c287f8";
        private string _colorBonus  = "#ffffff";
        public async Task<List<LessonGroup>> GetLessonsGroup()
        {
            return await Task.Run(() =>
            {
                return new List<LessonGroup>
                    {
                        new LessonGroup
                        {
                            Type = LessonGroupTypeEnum.Single,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Introduction", "4", "lesson_egg", _colorLevel5)
                            }
                        },

                        new LessonGroup
                        {
                            Type = LessonGroupTypeEnum.Multi,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Greetings", "4", "lesson_dialog", _colorLevel4),
                                GetNewLesson("Travel", string.Empty, "lesson_airplane", _colorLevel3)
                            }
                        },

                        new LessonGroup
                        {
                            Type = LessonGroupTypeEnum.Multi,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Food", string.Empty, "lesson_hamburger", _colorLevel2),
                                GetNewLesson("Family", string.Empty, "lesson_baby", _colorLevel1),
                            }
                        },

                        new LessonGroup
                        {
                            Type = LessonGroupTypeEnum.Bonus,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Bonus", string.Empty, "lesson_plus", _colorBonus),
                                GetNewLesson("Bonus", string.Empty, "lesson_plus", _colorBonus),
                                GetNewLesson("Bonus", string.Empty, "lesson_plus", _colorBonus)
                            }
                        },

                        new LessonGroup
                        {
                            Type = LessonGroupTypeEnum.Multi,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Store", string.Empty, "lesson_sock", _colorLevel0),
                                GetNewLesson("Study", "1", "lesson_pencil", _colorLevel1),
                                GetNewLesson("Profession", "2", "lesson_hat", _colorLevel2)
                            }
                        },

                        new LessonGroup
                        {
                            Type = LessonGroupTypeEnum.Single,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson("Meet", "1", "lesson_bag", _colorLevel1)
                            }
                        },

                        new LessonGroup
                        {
                            Type = LessonGroupTypeEnum.Divisor,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson(string.Empty, "2", "lesson_divisor_castle", string.Empty)
                            }
                        },

                        new LessonGroup
                        {
                            Type = LessonGroupTypeEnum.Divisor,
                            Lessons = new List<Lesson>
                            {
                                GetNewLesson(string.Empty, "2", "lesson_divisor_castle", string.Empty)
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
