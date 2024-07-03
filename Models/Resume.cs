using System.Collections.Generic;

namespace ResumeApp.Models
{
    public class Resume
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<string> Skills { get; set; }
    }

    public class Experience
    {
        public string Company { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class Education
    {
        public string School { get; set; }
        public string Degree { get; set; }
        public string Field { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
