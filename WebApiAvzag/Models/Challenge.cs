namespace WebApiAvzag.Models
{
    public class Challenge
    {
        public string Passage { get; set; } = "";
        public List<Token> PassageTokens { get; set; } = new();
        public string Promt { get; set; } = "";
        public List<Token> QuestionTokens { get; set; } = new();
        public List<string> Choices { get; set; } = new();
        public List<QuestionOptions> Options { get; set; } = new();
        public int CorrectIndex { get; set; }
        public string TTS { get; set; } = "";
        public string Type { get; set; } = "";
        public string Id { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
    }
}