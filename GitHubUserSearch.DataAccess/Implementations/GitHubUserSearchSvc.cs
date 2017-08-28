using GitHubUserSearch.DataAccess.Interfaces;
using GitHubUserSearch.DataAccess.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;


namespace GitHubUserSearch.DataAccess.Implementations
{
    public class GitHubUserSearchSvc : IGitHubUserSearchSvc<GitHubUser, GitHubRepo>
    {
        private readonly IBaseUrl _baseUrl;
        private readonly IGitHubSettings _githubsettings;
        public GitHubUserSearchSvc(IBaseUrl baseUrl, IGitHubSettings githubsettings)
        {
            _baseUrl = baseUrl;
            _githubsettings = githubsettings;

        }

        public GitHubUser GetUser(string userName)
        {
            var responseData = _baseUrl.BaseUrl(string.Format(_githubsettings.Repos_Url, userName));
            var gitHubUser = JsonConvert.DeserializeObject<GitHubUser>(responseData);

            if (gitHubUser == null)
            {
                return new GitHubUser();
            }

            gitHubUser.Repos =
                GetRepos(gitHubUser.ReposUrl)
                    .OrderByDescending(x => x.Stars)
                    .Take(_githubsettings.NoOfReposToShow)
                    .ToList();

            return gitHubUser;
        }

        public IList<GitHubRepo> GetRepos(string url)
        {
            var responseData = _baseUrl.BaseUrl(url);
            return JsonConvert.DeserializeObject<List<GitHubRepo>>(responseData);
        }

    }
}