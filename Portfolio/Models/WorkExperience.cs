namespace Portfolio.Models
{
    public class WorkExperience
    {
        public string Title { get; set; } = "";
        public string Company { get; set; } = "";
        public List<string> Tasks { get; set; } = new();
        public List<string> TechStack { get; set; } = new List<string>();
        public string CompanyUrl { get; set; } = "";
        public string YearRange { get; set; } = "";
    }
}
