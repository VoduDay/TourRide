﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourRide.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }

        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
    }
}