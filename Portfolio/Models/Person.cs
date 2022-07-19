using System;
using System.Collections.Generic;

namespace Portfolio.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string Occupation { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public virtual IEnumerable<Project> Projects { get; set; }
    }
}
