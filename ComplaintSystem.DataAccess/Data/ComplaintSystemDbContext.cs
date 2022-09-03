using ComplaintSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.DataAccess.Data
{
    public class ComplaintSystemDbContext : DbContext
    {

        public ComplaintSystemDbContext(DbContextOptions<ComplaintSystemDbContext> options) : base(options)
        {

        }
        public DbSet<Complaint> Complaints { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Complaint>().OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Complaint>().HasData(

                new Complaint { Id = 1, Name = "Apple Sarj", Type = "Telefon" },
                new Complaint { Id = 2, Name = "Siemens Mikrodalga Kapak", Type = "Beyaz Eşya" },
                new Complaint { Id = 3, Name = "Samsung TV Modem", Type = "Televizyon" }
                           
                );


        }

    }
}