using GitHubApi.Comunication;
using GitHubApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GitHubApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RepositoriesController : ControllerBase
    {
        /// <summary>
        /// Send a request to GitHub API and filter the result
        /// </summary>
        /// <returns>Returns the repositorie from an organization with C# as principal language.</returns>
        /// <param name="org">Name of organization on GitHub.</param>
        /// <param name="index">Requested position.</param>
        [HttpGet]
        public Repositorie Get(string org, int index)
        {
            try
            {
                return GitHub.RecuperaRepositorios(org)
                    .Where(r => r.language == "C#")
                    .OrderBy(r => r.created_at)
                    .ToList()[index];
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }
    }
}
