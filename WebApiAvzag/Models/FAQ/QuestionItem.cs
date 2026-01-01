namespace WebApiAvzag.Models.FAQ
{
    public class QuestionItem
    {
        public QuestionItem(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }

        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
