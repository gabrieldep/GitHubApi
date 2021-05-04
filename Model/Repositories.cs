using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubApi.Model
{
    public class Repositories
    {
        public long id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public Organization owner { get; set; }
        public DateTime created_at { get; set; }
        public string language { get; set; }
    }
}
