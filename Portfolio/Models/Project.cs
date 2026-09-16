namespace Portfolio.Models
{
    public class Project
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImageLink { get; set; } = "";
        public string GitHubLink { get; set; } = "";
        public List<string> TechStack { get; set; } = new();
    }
}
