using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIST.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public int Studentcode { get; set; }
        public string Lastname { get; set; }
        public string Prefix { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Postcode { get; set; }
        public string Residence { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthdate { get; set; }
        public int? ParentID { get; set; }
    }

    public class Parent
    {
        public int Id { get; set; }
        public int ParentID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class Teacher
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string Lastname { get; set; }
        public string Prefix { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Postcode { get; set; }
        public string Residence { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
