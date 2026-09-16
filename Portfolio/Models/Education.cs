namespace Portfolio.Models
{
    public class Education
    {
        public string Title { get; set; } = "";
        public string University { get; set; } = "";
        public string ThesisName { get; set; } = "";
        public string ThesisDescription { get; set; } = "";
        public string Coursework { get; set; } = "";
        public string YearRange { get; set; } = "";
        public List<string> TechStack { get; set; } = new List<string>();
    }
}
