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
                Passage = "Дзул ма мын рат…",
                Question = "Уый фанды…",
                Choices = new List<string> { "дзурын", "назын", "харын" },
                CorrectIndex = 2,
                Type = "readComprehension"
            },
            new Challenge
            {
                Passage = "Hallo. Wasser, bitte.",
                Question = "What does he want?",
                Choices = new List<string> { "Food", "Water", "Coffee" },
                CorrectIndex = 1,
                Type = "readComprehension"
            },
            new Challenge
            {
                Passage = "Ich trinke Kaffee.",
                Question = "What is he doing?",
                Choices = new List<string> { "Eating", "Drinking", "Sleeping" },
                CorrectIndex = 1,
                Type = "readComprehension"
            },
            new Challenge
            {
                Question = "Wie sagt man 'hello' auf Deutsch?",
                Choices = new List<string> { "Auf Wiedersehen", "Danke", "Hallo", "Bitte" },
                CorrectIndex = 2,
                Type = "select"
            },
            new Challenge
            {
                Question = "Wie sagt man 'thank you' auf Deutsch?",
                Choices = new List<string> { "Hallo", "Bitte", "Danke", "Tschüss" },
                CorrectIndex = 2,
                Type = "select"
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
