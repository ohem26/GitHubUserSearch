using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubUserSearch.DataAccess.Interfaces
{
   public interface IGitHubUserSearchSvc<out TUser,TRepos>
    {
        //User name to fetch associated repos
        TUser GetUser(string userName);

        IList<TRepos> GetRepos(string url);
    }
}
