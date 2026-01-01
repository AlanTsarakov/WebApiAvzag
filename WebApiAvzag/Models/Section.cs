namespace WebApiAvzag.Models
{
    public class SectionData
    {
        public Section Section { get; set; }
    }

    public class Section
    {
        public string Name { get; set; }
        public int TotalChaptersInUnit { get; set; }
        public int TotalUnitsInSection { get; set; }
        public List<Unit> Units { get; set; }
    }

    public class Unit
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Chapters { get; set; }
    }
}
