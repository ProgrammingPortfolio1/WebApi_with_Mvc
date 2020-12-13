using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using System.Web.Script.Serialization;

namespace WebApplication1.Controllers
{
    public class UsersController : ApiController
    {
        List<User> userslist = new List<User>();
        User user1 = new User();

        // GET: api/Users
        public IEnumerable<User> Get()
        {
            string url = "https://jsonplaceholder.typicode.com/users";

            var client = new WebClient();

            var text = client.DownloadString(url);

            JavaScriptSerializer ser = new JavaScriptSerializer();

            userslist = JsonConvert.DeserializeObject<List<User>>(text);

            return userslist;

            //return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        public User Get(int id)
        {
            string url = "https://jsonplaceholder.typicode.com/users/" + id.ToString();

            var client = new WebClient();

            var text = client.DownloadString(url);

            JavaScriptSerializer ser = new JavaScriptSerializer();

            user1 = JsonConvert.DeserializeObject<User>(text);

            return user1;

            //return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
