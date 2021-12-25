using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework.Models
{
    public class Teacher
    {
        public int id;
        public string fullName;
        public int salery;
        public int firstYear;
        public string[] StudySubjects;

        public Teacher(int id, string fullName, int salery, int firstYear, string[] studySubjects)
        {
            this.id = id;
            this.fullName = fullName;
            this.salery = salery;
            this.firstYear = firstYear;
            this.StudySubjects = studySubjects;
        }
    }
}