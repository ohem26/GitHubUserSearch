using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace GitHubUserSearch.DataAccess.Model
{
    public class User
    {
        [JsonProperty("login")]
        public string UserName { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("Avatar_url")]
        public string Avatar { get; set; }
    }
}