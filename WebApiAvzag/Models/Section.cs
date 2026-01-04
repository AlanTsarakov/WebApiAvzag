namespace WebApiAvzag.Models
{
    public class SectionData
    {
        public Section Section { get; set; } = new Section();
    }

    public class Section
    {
        public string Name { get; set; } = string.Empty;
        public int TotalChaptersInUnit { get; set; } = 0;
        public int TotalUnitsInSection { get; set; } = 0;
        public List<Unit> Units { get; set; } = [];
    }

    public class Unit
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> Chapters { get; set; } = [];
    }
}
