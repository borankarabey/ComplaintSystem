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
        public DbSet<Complaint> Complaints { get; set; }
    }
}
