using ComplaintSystem.Dtos.Responses;
using ComplaintSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Business
{
    public class FakeComplaintService : IComplaintService
    {
        private List<Complaint> complaints;

        public FakeComplaintService()
        {
            complaints = new List<Complaint>
            {
            new Complaint {Id = 1, Name = "Apple Sarj", Type = "Telefon"},
            new Complaint { Id = 2, Name = "Siemens Mikrodalga Kapak", Type = "Beyaz Eşya" },
            new Complaint { Id = 3, Name = "Samsung TV Modem", Type = "Televizyon" },
            };
        }

        public Task<int> AddComplaint(Complaint complaint)
        {
            throw new NotImplementedException();
        }

        public ICollection<Complaint> GetComplaints()
        {
            return complaints;
        }

        /* Task<ICollection<Complaint>> IComplaintService.GetComplaints()
        {
            throw new NotImplementedException();
        } */


        Task<ICollection<ComplaintListResponse>> IComplaintService.GetComplaints()
        {
            throw new NotImplementedException();
        }
    }
}
