using homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace homework.Controllers.API
{
    public class User1Controller : ApiController
    {

        User[] arrayofusers = new User[] { new User(0, "tikva", "yosef", 1996, true) };


        // GET: api/User1
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User1/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User1
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User1/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User1/5
        public void Delete(int id)
        {
        }
    }
}
