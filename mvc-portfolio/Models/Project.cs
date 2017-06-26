using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_portfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string DemoPath { get; set; }
        public string RepoPath { get; set; }
        public string[] TechUsed { get; set; }
    }
}