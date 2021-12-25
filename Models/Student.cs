using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework.Models
{
    public class Student
    {
        public int id;
        public string fullName;
        public int class_;
        public int yearOfBirth;
        public int[] grades;

        public Student(int id, string fullName, int class_, int yearOfBirth, int[] grades)
        {
            this.id = id;
            this.fullName = fullName;
            this.class_ = class_;
            this.yearOfBirth = yearOfBirth;
            this.grades = grades;
        }
    }
}