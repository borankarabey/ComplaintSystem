﻿using ComplaintSystem.DataAccess.Data;
using ComplaintSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.DataAccess.Repositories
{
    public class EFComplaintRepository : IComplaintRepository
    {
        private ComplaintSystemDbContext context;

        public EFComplaintRepository(ComplaintSystemDbContext context)
        {
            this.context = context;
        }

        public async Task<int> Add(Complaint entity)
        {
            await context.Complaints.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity.Id; 
        }

        public async Task Delete(int id)
        {
            var complaint = await context.Complaints.FirstOrDefaultAsync(c => c.Id == id);
            context.Complaints.Remove(complaint);
            await context.SaveChangesAsync();
        }

        public async Task<IList<Complaint>> GetAllEntities()
        {
            return await context.Complaints.ToListAsync();
        }

        public async Task<Complaint> GetEntityById(int id)
        {
            return await context.Complaints.FindAsync(id);
        }

        public async Task<IList<Complaint>> SearchComplaintByName(string name)
        {
            return await context.Complaints.Where(c => c.Name.Contains(name)).ToListAsync();
        }

        public async Task<int> Update(Complaint entity)
        {
            context.Complaints.Update(entity);
            return await context.SaveChangesAsync();
        }
    }
}
