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
        List<User> listOfUsers = new List<User>();

        void Showusers()
        {
           
            User[] arrayofusers = new User[] { new User(0, "tikva", "yosef", 1996, true), new User(1, "keren", "hailu", 1998, false) };
            //User.listofusers.AddRange(arrayofusers);
            listOfUsers.AddRange(arrayofusers);
        }

        // GET: api/User1
        public IHttpActionResult Get()
        {
            Showusers();
            return Ok(listOfUsers);
        }

        // GET: api/User1/5
        public IHttpActionResult Get(int id)
        {
            Showusers();
            User sameuser = listOfUsers.Find(item => item.id == id);
            return Ok(sameuser);
        }

        // POST: api/User1
        public IHttpActionResult Post([FromBody] User value)
        {
            List<User> newuser = new List<User>();
            newuser.Add(value);
            return Ok(newuser);
        }

        // PUT: api/User1/5
        public IHttpActionResult Put(int id, [FromBody] User value)
        {
            Showusers();
            User sameuser = listOfUsers.Find(item => item.id == id);
            listOfUsers[listOfUsers.IndexOf(sameuser)].firstName = value.firstName;
            listOfUsers[listOfUsers.IndexOf(sameuser)].lastName = value.lastName;
            listOfUsers[listOfUsers.IndexOf(sameuser)].year = value.year;
            listOfUsers[listOfUsers.IndexOf(sameuser)].conected = value.conected;

            listOfUsers.Add(sameuser);
            return Ok(listOfUsers);
        }

        // DELETE: api/User1/5
        public IHttpActionResult Delete(int id)
        {
            Showusers();
            User sameuser = listOfUsers.Find(item => item.id == id);
            listOfUsers.Remove(sameuser);
            return Ok(listOfUsers);
        }
    }
}
