using System.Text.Json;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class FileReader
    {
        private readonly ILogger<FileReader> _logger;
        private readonly IWebHostEnvironment _webEnv;

        public FileReader(ILogger<FileReader> logger, IWebHostEnvironment webEnv)
        {
            _logger = logger;
            _webEnv = webEnv;
        }

        public List<WorkExperience> LoadWorkExperience()
        {
            try
            {
                var path = Path.Combine(_webEnv.WebRootPath, "data", "experience.json");
                var data = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<WorkExperience>>(data) ?? new List<WorkExperience>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load experience data from JSON file.");
                return new List<WorkExperience>();
            }
        }

        public List<Education> LoadEducation()
        {
            try
            {
                var path = Path.Combine(_webEnv.WebRootPath, "data", "studies.json");
                var data = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<Education>>(data) ?? new List<Education>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load school data from JSON file.");
                return new List<Education>();
            }
        }

        public List<Project> LoadProjects()
        {
            try
            {
                var path = Path.Combine(_webEnv.WebRootPath, "data", "projects.json");
                var data = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<Project>>(data) ?? new List<Project>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load project data from JSON file.");
                return new List<Project>();
            }
        }
    }
}
