namespace WebApiAvzag.Models
{
    public class ChallengeResponse
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string LearningLanguage { get; set; } = "de";
        public string FromLanguage { get; set; } = "en";
        public string Type { get; set; } = "LEXEME_SKILL_LEVEL_PRACTICE";
        public List<Challenge> Challenges { get; set; } = new();
    }
}
