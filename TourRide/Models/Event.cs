using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourRide.Models
{
    
    public class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventId { get; set; }
        public string Title { get; set; }
        public DateTime EventTime { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}