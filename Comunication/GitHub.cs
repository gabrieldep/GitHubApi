using ApiTakeBlip.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiTakeBlip.Comunication
{
    public class GitHub
    {

        /// <summary>
        /// Send a get requisition to GitHub API
        /// </summary>
        /// <returns>List with data from an org repositories</returns>
        internal static IList<Repositories> RecuperaRepositorios(string org)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://api.github.com/")
            };
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "http://developer.github.com/v3/#user-agent-required");

            using HttpResponseMessage response = client.GetAsync($"orgs/{org}/repos").Result;
            if (response.IsSuccessStatusCode)
            {
                IList<Repositories> json = JsonConvert.DeserializeObject<IList<Repositories>>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                return json;
            }
            else
            {
                return null;
            }
        }
    }
}
