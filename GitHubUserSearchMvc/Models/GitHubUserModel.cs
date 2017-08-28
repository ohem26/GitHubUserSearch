using GitHubUserSearch.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GitHubUserSearchMvc.Models
{
    public class GitHubUserModel
    {
        public GitHubUserModel()
        {
            this.GitHubRepos= new List<GitHubRepo>();
        }

        [Required]
        public string UserName { get; set; }
        public string Location { get; set; }
        public string Avatar { get; set; }

        public IList<GitHubRepo> GitHubRepos { get; set; }
    }
}