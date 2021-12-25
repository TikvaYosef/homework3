using homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace homework.Controllers.API
{
    public class Student1Controller : ApiController
    {
        List<Student> listOfStudent = new List<Student>();

        void Students()
        {
            Student[] arrayofstudents = new Student[] { new Student(0, "tikva yosef",12, 1996,new int[] { 100, 80, 90 }), new Student(1, "keren hailu",8, 1998, new int[] { 90, 80, 70 }) };
            listOfStudent.AddRange(arrayofstudents);
        }



        // GET: api/Student1
        public IHttpActionResult Get()
        {
            Students();
            return Ok(listOfStudent);
        }

        // GET: api/Student1/5
        public IHttpActionResult Get(int id)
        {
            Students();
            Student samestudent = listOfStudent.Find(item => item.id == id);
            return Ok(samestudent);
        }

        // POST: api/Student1
        public IHttpActionResult Post([FromBody] Student value)
        {
            List<Student> newStudent = new List<Student>();
            newStudent.Add(value);
            return Ok(newStudent);
        }

        // PUT: api/Student1/5
        public IHttpActionResult Put(int id, [FromBody]Student value)
        {
            Students();
            Student sameStudent = listOfStudent.Find(item => item.id == id);
            listOfStudent[listOfStudent.IndexOf(sameStudent)].fullName = value.fullName;
            listOfStudent[listOfStudent.IndexOf(sameStudent)].class_ = value.class_;
            listOfStudent[listOfStudent.IndexOf(sameStudent)].yearOfBirth = value.yearOfBirth;
            listOfStudent[listOfStudent.IndexOf(sameStudent)].grades = value.grades;

            listOfStudent.Add(sameStudent);
            return Ok(listOfStudent);
        }

        // DELETE: api/Student1/5
        public IHttpActionResult Delete(int id)
        {
            Students();
            Student sameuStudent = listOfStudent.Find(item => item.id == id);
            listOfStudent.Remove(sameuStudent);
            return Ok(listOfStudent);
        }
    }
}
