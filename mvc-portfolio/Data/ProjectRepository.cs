using mvc_portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace mvc_portfolio.Data
{
    public class ProjectRepository
    {
        private static Project[] _projects = new Project[]
        {
            new Project()
            {
                Id = 1,
                Title = "FreeCodeCamp - SLC Directory",
                ImagePath = "fcc-directory.PNG",
                DemoPath = "https://directory-fcc-slc.firebaseapp.com/",
                RepoPath = "https://github.com/briancbarrow/fcc-directory",
                TechUsed = new string[]
                {
                    "React",
                    "Node.js",
                    "Mongoose",
                    "Express"
                }
            },

            new Project()
            {
                Id = 2,
                Title = "Basketball Battle App",
                ImagePath = "bball-battle.PNG",
                DemoPath = "http://bball-battle.herokuapp.com/",
                RepoPath = "https://github.com/briancbarrow/bball-battle",
                TechUsed = new string[]
                {
                    "React",
                    "Node.js",
                    "Mongoose",
                    "Express"
                }
            },

            new Project()
            {
                Id = 3,
                Title = "Meetup Finder",
                ImagePath = "meetupFinder1.PNG",
                DemoPath = "https://meetup-finder.firebaseapp.com/",
                RepoPath = "https://github.com/briancbarrow/meetup-finder",
                TechUsed = new string[]
                {
                    "AJAX",
                    "CSS",
                    "JavaScript",
                    "HTML"
                }
            },

            new Project()
            {
                Id = 4,
                Title = "NBA Salary Per Minute",
                ImagePath = "bballdata.PNG",
                DemoPath = "https://fast-dusk-74105.herokuapp.com/",
                RepoPath = "https://github.com/briancbarrow/node-capstone",
                TechUsed = new string[]
                {
                    "D3.js",
                    "Node.js",
                    "MongoDB",
                    "Express"
                }
            },

            new Project()
            {
                Id = 5,
                Title = "Simon Game",
                ImagePath = "Simon.PNG",
                DemoPath = "https://briancbarrow.github.io/simon-game/",
                RepoPath = "https://github.com/briancbarrow/simon-game",
                TechUsed = new string[]
                {
                    "JavaScript",
                    "CSS",
                    "HTML"
                }
            },

            new Project()
            {
                Id = 6,
                Title = "Pomodoro Timer",
                ImagePath = "Pomodoro.PNG",
                DemoPath = "https://briancbarrow.github.io/pomodoro/",
                RepoPath = "https://github.com/briancbarrow/pomodoro",
                TechUsed = new string[]
                {
                    "JavaScript",
                    "CSS",
                    "HTML"
                }
            },

            new Project()
            {
                Id = 7,
                Title = "FCC Tribute Page",
                ImagePath = "tribute.PNG",
                DemoPath = "http://brianb-fcc-tributepage.azurewebsites.net/",
                RepoPath = "https://github.com/briancbarrow/tribute",
                TechUsed = new string[]
                {
                    ".NET MVC",
                    "Razor",
                    "C#",
                    "HTML"
                }
            },
        };

        public Project[] GetProjects()
        {
            return _projects;
        }
    }
}