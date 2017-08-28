using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubUserSearch.DataAccess.Interfaces
{
    public interface IGitHubSettings
    {
        string Repos_Url { get; }
        int NoOfReposToShow { get; }
    }
}
