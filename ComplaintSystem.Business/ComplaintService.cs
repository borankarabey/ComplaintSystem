using ComplaintSystem.Entities;
using ComplaintSystem.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplaintSystem.DataAccess.Repositories;

namespace ComplaintSystem.Business
{
    public class ComplaintService : IComplaintService
    {
        private readonly IComplaintRepository complaintRepository;
        
        public ComplaintService(IComplaintRepository complaintRepository)
        {
            this.complaintRepository = complaintRepository;
        }

        public async Task<ICollection<Complaint>> GetComplaints()
        {
            return await complaintRepository.GetAllEntities();
        }
    }
}
