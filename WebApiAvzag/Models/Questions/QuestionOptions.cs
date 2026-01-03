namespace WebApiAvzag.Models.Questions
{
    public class QuestionOptions
    {
        public QuestionOptions(string text, string tTS)
        {
            Text = text;
            TTS = tTS;
        }

        public string Text { set; get; }
        public string TTS { set; get; }
    }
}