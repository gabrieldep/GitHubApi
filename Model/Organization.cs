using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubApi.Model
{
    public class Organization
    {
        public string login { get; set; }
        public long id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_url { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string follower_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
    }
}
