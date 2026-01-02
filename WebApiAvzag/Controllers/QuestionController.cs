using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAvzag.Models;

namespace WebApiAvzag.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {

        // Данные для упражнений на немецком
        private static readonly List<Challenge> _germanChallenges = new()
        {
            new Challenge
            {
                Passage = "Дон ма мын рат…",
                Promt = "Уый фанды…",
                Choices = new List<string> { "дзурын", "назын", "харын" },
                CorrectIndex = 2,
                TTS = "https://drive.google.com/file/d/1n5psZk2XnbbxHfgLu7uAspfud97UnbYh/view?usp=sharing",
                Type = "readComprehension",
                Options = new List<QuestionOptions>{new QuestionOptions("дзурын", "https://drive.google.com/uc?export=download&id=1n5psZk2XnbbxHfgLu7uAspfud97UnbYh"), new QuestionOptions("назын", "https://drive.google.com/uc?export=download&id=1n5psZk2XnbbxHfgLu7uAspfud97UnbYh"), new QuestionOptions("харын", "https://drive.google.com/uc?export=download&id=1n5psZk2XnbbxHfgLu7uAspfud97UnbYh") }
            },
            new Challenge
            {
                Passage = "Hallo. Wasser, bitte.",
                Promt = "What does he want?",
                Choices = new List<string> { "Food", "Water", "Coffee" },
                CorrectIndex = 1,
                Type = "readComprehension"
            },
            new Challenge
            {
                Passage = "Ich trinke Kaffee.",
                Promt = "What is he doing?",
                Choices = new List<string> { "Eating", "Drinking", "Sleeping" },
                CorrectIndex = 1,
                Type = "readComprehension"
            },
            new Challenge
            {
                Promt = "Wie sagt man 'hello' auf Deutsch?",
                Choices = new List<string> { "Auf Wiedersehen", "Danke", "Hallo", "Bitte" },
                CorrectIndex = 2,
                Type = "select"
            },
            new Challenge
            {
                Promt = "Wie sagt man 'thank you' auf Deutsch?",
                Choices = new List<string> { "Hallo", "Bitte", "Danke", "Tschüss" },
                CorrectIndex = 2,
                Type = "select",
                Options = new List<QuestionOptions>{new QuestionOptions("sd", "SDs")}
            }
        };

        [HttpGet(Name = "question")]
        public ActionResult Index()
        {
            var randomChallenge = _germanChallenges[0];
            var response = new ChallengeResponse
            {
                Challenges = new List<Challenge> { randomChallenge }
            };
            return Ok(response);
        }

        
    }
}
