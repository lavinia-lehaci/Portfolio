namespace Portfolio.Models
{
    public class HomeViewModel
    {
        public List<WorkExperience> WorkExperience { get; set; } = new();
        public List<Education> Education { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
    }
}
