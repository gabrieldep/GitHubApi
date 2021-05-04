using GitHubApi.Comunication;
using GitHubApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RepositoriesController : ControllerBase
    {
        /// <summary>
        /// Send a requisition to GitHub API and filter the result
        /// </summary>
        /// <returns>Returns the first five repositories from an organization with C# as principal language in order of creation.</returns>
        [HttpGet]
        public IEnumerable<Repositories> Get(string org)
        {
            return GitHub.RecuperaRepositorios(org)
                .Where(r => r.language == "C#")
                .OrderBy(r => r.created_at)
                .ToList().Take(5);
        }
    }
}
