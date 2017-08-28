using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace GitHubUserSearch.DataAccess.Model
{
    public class GitHubUser:User
    {

        [JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        [JsonIgnore]
       public  IList<GitHubRepo> Repos { get; set; }
    }
}