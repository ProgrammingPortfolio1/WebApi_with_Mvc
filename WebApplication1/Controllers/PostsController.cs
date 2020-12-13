using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PostsController : ApiController
    {
        List<Post> postslist = new List<Post>();
        Post post1 = new Post();

        // GET: api/Posts
        public IEnumerable<Post> Get()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            var client = new WebClient();

            var text = client.DownloadString(url);

            JavaScriptSerializer ser = new JavaScriptSerializer();

            postslist = JsonConvert.DeserializeObject<List<Post>>(text);

            return postslist;

            //return new string[] { "value1", "value2" };
        }

        // GET: api/Posts/5
        public Post Get(int id)
        {
            string url = "https://jsonplaceholder.typicode.com/posts/" + id.ToString();

            var client = new WebClient();

            var text = client.DownloadString(url);

            JavaScriptSerializer ser = new JavaScriptSerializer();

            post1 = JsonConvert.DeserializeObject<Post>(text);

            return post1;

            //return "value";
        }

        // POST: api/Posts
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Posts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Posts/5
        public void Delete(int id)
        {
        }
    }
}
