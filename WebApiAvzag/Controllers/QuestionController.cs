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
                        CorrectIndex = 1,
                        TTS = "../assets/audio/lesson_1_4.mp3",
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("разговор", "../assets/audio/lesson_1_1_1.mp3"), new QuestionOptions("привет", "../assets/audio/lesson_1_1_2.mp3"), new QuestionOptions("пчела", "../assets/audio/lesson_1_1_3.mp3") },
                    }),
                new Lesson(new Challenge()
                    {
                        Passage = "Ныхас",
                        Promt = "Переведите:",
                        CorrectIndex = 0,
                        TTS = "../assets/audio/lesson_1_4.mp3",
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("разговор", "../assets/audio/lesson_1_1_1.mp3"), new QuestionOptions("привет", "../assets/audio/lesson_1_1_2.mp3"), new QuestionOptions("пчела", "../assets/audio/lesson_1_1_3.mp3") },
                    },new Challenge()
                    {
                        Passage = "2Дон ма мын рат…",
                        Promt = "Что он хочет?",
                        CorrectIndex = 1,
                        TTS = "../assets/audio/lesson_1_1.mp3",
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("дзурын", "../assets/audio/lesson_1_1_1.mp3"), new QuestionOptions("назын", "../assets/audio/lesson_1_1_2.mp3"), new QuestionOptions("харын", "../assets/audio/lesson_1_1_3.mp3") },
                    },new Challenge()
                    {
                        Passage = "2Дон ма мын рат…",
                        Promt = "Что он хочет?",
                        CorrectIndex = 1,
                        TTS = "../assets/audio/lesson_1_1.mp3",
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("дзурын", "../assets/audio/lesson_1_1_1.mp3"), new QuestionOptions("назын", "../assets/audio/lesson_1_1_2.mp3"), new QuestionOptions("харын", "../assets/audio/lesson_1_1_3.mp3") },
                    },new Challenge()
                    {
                        Passage = "2Дон ма мын рат…",
                        Promt = "Что он хочет?",
                        CorrectIndex = 1,
                        TTS = "../assets/audio/lesson_1_1.mp3",
                        Type = "readComprehension",
                        Choices = new List<QuestionOptions>{new QuestionOptions("дзурын", "../assets/audio/lesson_1_1_1.mp3"), new QuestionOptions("назын", "../assets/audio/lesson_1_1_2.mp3"), new QuestionOptions("харын", "../assets/audio/lesson_1_1_3.mp3") },
                    }) 
            });

        [HttpGet(Name = "question")]
        public ActionResult Index(int sectionId, int chapter, int lesson)
        {
            return Ok(chapter1.Lessons[lesson-1].Challenges);
        }


    }
}
