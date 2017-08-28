using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitHubUserSearch.DataAccess.Interfaces
{
    public interface IBaseUrl
    {
        string BaseUrl(string url);
    }
}