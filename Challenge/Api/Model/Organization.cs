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
        public string avatar_url { get; set; }
        public string url { get; set; }
    }
}
