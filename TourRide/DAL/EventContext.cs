using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TourRide.Models;

namespace TourRide.DAL
{
    public class EventContext : DbContext
    {
        public EventContext() : base("EventContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}