using Microsoft.AspNetCore.Mvc.RazorPages;
using ResumeApp.Models;
using System.Collections.Generic;

namespace ResumeApp.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; }

        public void OnGet()
        {
            Projects = new List<Project>
            {
                new Project
                {
                    Title = "home automation system",
                    Description = "Developed a working prototype for home automation\r\nsystem using Arduino, programmed using C++",
                    Technology = "C, Arduino, IOT"
                    
                },
                new Project
                {
                    Title = "IPL Analysis",
                    Description = "Developed a visualizing website using Python for graphical\r\nrepresentation of cricket scores and its players, Hosted it\r\nonline using apache.",
                    Technology = "Python and its visualization libraries."
                    
                },
                new Project
                {
                    Title = "Major Project",
                    Description = "Containerized an application using Docker And Gave a Solution for deploying the apps using kubernetes and applying load balancing.",
                    Technology = "Docker, Kubernetes, Python",
                    Link = "https://github.com/Ashutosh-51/MinorP"
                }
            };
        }
    }
}
