using homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace homework.Controllers.API
{
    public class Teacer1Controller : ApiController
    {
        List<Teacher> listOfTeachers = new List<Teacher>();

        void showTeachers()
        {
          
                Teacher[] arrayofTeachers = new Teacher[] { new Teacher(0, "tikva yosef", 10000,2010,new string[] { "fds", "fef", "fesf" }), new Teacher(1, "keren hailu", 8, 1998, new string[] { "grsd", "gdsgh", "gs" }) };
                 listOfTeachers.AddRange(arrayofTeachers);
            
        }

        // GET: api/Teacer1
        public IHttpActionResult  Get()
        {
            showTeachers();
            return Ok(listOfTeachers);
        }

        // GET: api/Teacer1/5
        public IHttpActionResult Get(int id)
        {
            showTeachers();
            Teacher sameTeacher = listOfTeachers.Find(item => item.id == id);
            return Ok(sameTeacher);
        }

        // POST: api/Teacer1
        public IHttpActionResult Post([FromBody]Teacher value)
        {

            List<Teacher> sameTeacher = new List<Teacher>();
            sameTeacher.Add(value);
            return Ok(sameTeacher);
        }

        // PUT: api/Teacer1/5
        public IHttpActionResult Put(int id, [FromBody]Teacher value)
        {
            showTeachers();
            Teacher sameTeacher = listOfTeachers.Find(item => item.id == id);
            listOfTeachers[listOfTeachers.IndexOf(sameTeacher)].fullName = value.fullName;
            listOfTeachers[listOfTeachers.IndexOf(sameTeacher)].salery = value.salery;
            listOfTeachers[listOfTeachers.IndexOf(sameTeacher)].firstYear = value.firstYear;
            listOfTeachers[listOfTeachers.IndexOf(sameTeacher)].StudySubjects = value.StudySubjects;

            listOfTeachers.Add(sameTeacher);
            return Ok(listOfTeachers);
        }

        // DELETE: api/Teacer1/5
        public IHttpActionResult Delete(int id)
        {
            showTeachers();
            Teacher sameTeacher = listOfTeachers.Find(item => item.id == id);
            listOfTeachers.Remove(sameTeacher);
            return Ok(listOfTeachers);
        }
    }
}
