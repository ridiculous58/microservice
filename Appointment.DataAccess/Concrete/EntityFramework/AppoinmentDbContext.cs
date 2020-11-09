using Appointment.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appointment.DataAccess.Concrete.EntityFramework
{
    public class AppoinmentDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = 127.0.0.1; port = 5432; user id =postgres; password=Esdea_68_00; database = AppointmentDB; pooling = true;Integrated Security=true");
            
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SessionCategory> SessionCategories { get; set; }
        public DbSet<SessionReceipt> SessionReceipts { get; set; }

    }
}
