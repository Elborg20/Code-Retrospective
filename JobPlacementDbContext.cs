using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using JobPlacementDashboard.Models;

namespace JobPlacementDashboard.DAL
{
    public class JobPlacementDbContext:DbContext
    {
        public JobPlacementDbContext() : base("JobPlacementDbContext")
        {

        }
        public DbSet<JPStudent> JPStudents { get; set; }
        public DbSet<JPApplication> JPApplications { get; set; }
        public DbSet<JPHire> JPHires { get; set; }
        public DbSet<JPBulletin> JPBulletins { get; set; }
        public DbSet<JPCurrentJob> JPCurrentJobs { get; set; }
        public DbSet<JPLatestContact> JPLatestContacts { get; set; }
        public DbSet<JPChecklist> JPChecklists { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<JPMeetupEvent> JPMeetupEvents { get; set; }
        public DbSet<JPNotification> JPNotifications { get; set; }
        public DbSet<JPOutsideNetworking> JPOutsideNetworkings { get; set; }
        public DbSet<JPMeetUpAttendee> JPMeetUpAttendees { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        
    }
}