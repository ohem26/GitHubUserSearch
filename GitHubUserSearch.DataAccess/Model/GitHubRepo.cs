using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace GitHubUserSearch.DataAccess.Model
{
    public class GitHubRepo
    {
        [JsonProperty("name")]
        public string ReposName { get; set; }

        [JsonProperty("html_url")]
        public string ReposUrl { get; set; }

        [JsonProperty("Stargazers_count")]
        public int Stars { get; set; }
    }
}