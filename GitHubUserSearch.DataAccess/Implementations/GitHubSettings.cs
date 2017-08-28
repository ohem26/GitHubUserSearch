using GitHubUserSearch.DataAccess.Interfaces;
using System.Configuration;

namespace GitHubUserSearch.DataAccess.Implementations
{
    public class GitHubSettings:IGitHubSettings
    {
        public string Repos_Url => string.IsNullOrEmpty(ConfigurationManager.AppSettings["GitHubURL"])
            ? string.Empty
            : ConfigurationManager.AppSettings["GitHubURL"];

        public int NoOfReposToShow => string.IsNullOrEmpty(ConfigurationManager.AppSettings["NoOfReposToShow"])
           ? 0
           : int.Parse(ConfigurationManager.AppSettings["NoOfReposToShow"]);
    }
}