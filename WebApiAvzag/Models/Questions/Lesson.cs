namespace WebApiAvzag.Models.Questions
{
    public class Lesson
    {
        public List<Challenge> Challenges { get; } = [];

        public Lesson(Challenge challenge1, Challenge challenge2, Challenge challenge3, Challenge challenge4)
        {
            Challenges.Add(challenge1);
            Challenges.Add(challenge2);
            Challenges.Add(challenge3);
            Challenges.Add(challenge4);
        }
    }
}
