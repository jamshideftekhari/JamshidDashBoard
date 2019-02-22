using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace JamshidDashBoard.Models
{
    public class MeasurementContext : DbContext
    {
        public MeasurementContext() : base("MeasurementContext")
        {
            
        }

        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<Record> Records { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}