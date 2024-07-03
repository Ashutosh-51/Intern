using Microsoft.AspNetCore.Mvc.RazorPages;
using ResumeApp.Models;
using System.Collections.Generic;

namespace ResumeApp.Pages
{
    public class ResumeModel : PageModel
    {
        public Resume Resume { get; set; }

        public void OnGet()
        {
            Resume = new Resume
            {
                Name = "Ashutosh",
                Address = "'Singh Niwas', Opp. A/13, " +
                "Harmu Housing Colony, Arvind Nagar",
                Phone = "6205661972",
                Email = "ashutosh.singhr51@gmail.com",
                Experiences = new List<Experience>
                {
                    new Experience
                    {
                        Company = "366pi",
                        Role = "Web Developer",
                        Description = "Developed web applications using ASP.NET Core.",
                        StartDate = "July 2024",
                        EndDate = "Present"
                    },
                    new Experience
                    {
                        Company = "Candent",
                        Role = "Basis Administrator",
                        Description = "Assisted ECC installatio, post installation, " +
                        "upgades, backup and Mnitoring",
                        StartDate = "July 2023",
                        EndDate = "September 2023"
                    }
                },
                Educations = new List<Education>
                {
                    new Education
                    {
                        School = "Kalinga Institute of Industrial Technology",
                        Degree = "Bachelor of Technology",
                        Field = "Computer Science",
                        StartDate = "August 2021",
                        EndDate = "June 2024"
                    }
                },
                Skills = new List<string>
                {
                    "C#",
                    "ASP.NET Core",
                    "JavaScript",
                    "SQL"
                }
            };
        }
    }
}
