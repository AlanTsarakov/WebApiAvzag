namespace WebApiAvzag.Models.Questions
{
    public class Chapter
    {
        public string Name { get; set; }
        public List<Lesson> Lessons = [];

        public Chapter(string name, List<Lesson> lessons)
        {
            Name = name;
            Lessons = lessons;
        }
    }
}
