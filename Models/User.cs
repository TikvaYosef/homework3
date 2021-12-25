using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework.Models
{
    public class User
    {
        public int id;
        public string firstName;
        public string lastName;
        public int year;
        public bool conected;


        public User(int id, string firstName, string lastName, int year, bool conected)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.conected = conected;
        }

        //public static List<User> listofusers = new List<User>();
    }
}