using ComplaintSystem.Entities;
using ComplaintSystem.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplaintSystem.Dtos.Requests;

namespace ComplaintSystem.Business
{
    public interface IComplaintService
    {
        Task<ICollection<ComplaintListResponse>> GetComplaints();

        Task<int> AddComplaint(AddComplaintRequest complaint);

    }
}
