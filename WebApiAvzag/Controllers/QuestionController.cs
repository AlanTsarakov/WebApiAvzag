using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAvzag.Models.Questions;

namespace WebApiAvzag.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {
        //section -> unit -> chapter -> lesson -> challenge

        private Chapter chapter1 = new Chapter("ds",
            new List<Lesson>() {
                new Lesson(new Challenge()
                    {
                        Passage = "Дон ма мын рат…",
                        Promt = "Что он хочет?",
                        CorrectIndex = 1,
                        TTS = "../assets/audio/lesson_1_1.mp3",
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("дзурын", "../assets/audio/lesson_1_1_1.mp3"), new QuestionOptions("назын", "../assets/audio/lesson_1_1_2.mp3"), new QuestionOptions("харын", "../assets/audio/lesson_1_1_3.mp3") },
                    },
                    new Challenge()
                    {
                        Passage = "Айда ныхас аканам",
                        Promt = "Что он хочет?",
                        Choices = new List<QuestionOptions>{new QuestionOptions("дзурын", "../assets/audio/lesson_1_1_1.mp3"), new QuestionOptions("назын", "../assets/audio/lesson_1_1_2.mp3"), new QuestionOptions("харын", "../assets/audio/lesson_1_1_3.mp3") },
                        CorrectIndex = 0,
                        TTS = "../assets/audio/lesson_1_3.mp3",
                        Type = "readComprehension"
                    },
                    new Challenge() 
                    {
                        Passage = "Дзул ма мын рат…",
                        Promt = "Что он хочет?",
                        Choices = new List<QuestionOptions>{new QuestionOptions("дзурын", "../assets/audio/lesson_1_1_1.mp3"), new QuestionOptions("назын", "../assets/audio/lesson_1_1_2.mp3"), new QuestionOptions("харын", "../assets/audio/lesson_1_1_3.mp3") },
                        CorrectIndex = 2,
                        TTS = "../assets/audio/lesson_1_2.mp3",
                        Type = "readComprehension"
                    },
                    new Challenge()
                    {
                        Passage = "Ныхас",
                        Promt = "Переведите:",
                        CorrectIndex = 0,
                        TTS = "",
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("разговор"), new QuestionOptions("привет"), new QuestionOptions("пчела") },
                    }),
                new Lesson(new Challenge()
                    {
                        Passage = "Салам",
                        Promt = "Переведите:",
                        CorrectIndex = 0,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("привет"), new QuestionOptions("пока"), new QuestionOptions("пчела") },
                    },new Challenge()
                    {
                        Passage = "Куыд да?",
                        Promt = "Переведите выражение:",
                        CorrectIndex = 1,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("Кто ты?"), new QuestionOptions("Как ты?"), new QuestionOptions("Где ты?")},
                    },new Challenge()
                    {
                        Passage = "Он",
                        Promt = "Переведите",
                        CorrectIndex = 0,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("Уый"), new QuestionOptions("Уыцы"), new QuestionOptions("Аз") },
                    },new Challenge()
                    {
                        Passage = "Я есть",
                        Promt = "Переведите",
                        CorrectIndex = 0,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("Аз дан"), new QuestionOptions("Уый у"), new QuestionOptions("Уыдон сты") },
                    }),
                new Lesson(new Challenge()
                    {
                        Passage = "Вчера",
                        Promt = "Переведите",
                        CorrectIndex = 0,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("Знон"), new QuestionOptions("Дзырд"), new QuestionOptions("Знон") },
                    },new Challenge()
                    {
                        Passage = "Идти",
                        Promt = "Переведите",
                        CorrectIndex = 2,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("Харын"), new QuestionOptions("Лидзын"), new QuestionOptions("Цауын") },
                    },new Challenge()
                    {
                        Passage = "Мед",
                        Promt = "Переведите с осетинского на русский",
                        CorrectIndex = 0,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("Мыд"), new QuestionOptions("Касаг"), new QuestionOptions("Дзидза") },
                    },new Challenge()
                    {
                        Passage = "Муха",
                        Promt = "Переведите",
                        CorrectIndex = 0,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("Бындз"), new QuestionOptions("Карк"), new QuestionOptions("Гогыз") },
                    }),
                new Lesson(new Challenge()
                    {
                        Passage = "Пчела",
                        Promt = "Переведите",
                        CorrectIndex = 0,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("Мыдыбындз"), new QuestionOptions("Бындз"), new QuestionOptions("Дон") },
                    },new Challenge()
                    {
                        Passage = "Хараг",
                        Promt = "Переведите",
                        CorrectIndex = 0,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("Осел"), new QuestionOptions("Индюк"), new QuestionOptions("Корова") },
                    },new Challenge()
                    {
                        Passage = "Фындз",
                        Promt = "Переведите",
                        CorrectIndex = 1,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("Рот"), new QuestionOptions("Нос"), new QuestionOptions("Язык") },
                    },new Challenge()
                    {
                        Passage = "Хадзар",
                        Promt = "Переведите",
                        CorrectIndex = 0,
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("Дом"), new QuestionOptions("Вода"), new QuestionOptions("Село") },
                    })

            });

        [HttpGet(Name = "question")]
        public ActionResult Index(int sectionId, int chapter, int lesson)
        {
            return Ok(chapter1.Lessons[lesson-1].Challenges);
        }


    }
}
