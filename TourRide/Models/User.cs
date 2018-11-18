using System;
using System.Collections.Generic;

namespace TourRide.Models
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Nickname { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}