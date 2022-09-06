using ComplaintSystem.Entities;
using ComplaintSystem.Dtos.Responses;
using ComplaintSystem.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplaintSystem.DataAccess.Repositories;
using ComplaintSystem.Dtos.Requests;
using AutoMapper;

namespace ComplaintSystem.Business
{
    public class ComplaintService : IComplaintService
    {
        private readonly IComplaintRepository complaintRepository;
        private readonly IMapper mapper;

        public ComplaintService(IComplaintRepository complaintRepository, IMapper mapper)
        {
            this.complaintRepository = complaintRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<ComplaintListResponse>> GetComplaints()
        {
            return await complaintRepository.GetAllEntities();
        }

        public async Task<int> AddComplaint(Complaint complaint)
        {
            var complaints = await complaintRepository.Add(complaint);
            var complaintListResponses = new List<ComplaintListResponse>();

            /*complaints.ToList().ForEach(complaint => complaintListResponses.Add(new ComplaintListResponse
            {
                Type = c.Type,
                Name = c.Name,
                Id = c.Id,
            }));
            */

            var complaintListResponses = mapper.Map<List<ComplaintListResponse>>(complaints);

            return complaintListResponses;
        }

        public async Task<int> AddComplaint(AddComplaintRequest request)
        {
            /*var complaint = new Complaint
            {
                CreatedDate = DateTime.Now,
                Type = request.Type,
                Name = request.Name,
            };*/

            var complaint = mapper.Map<Complaint>(request);

            return await complaintRepository.Add(complaint);
        }

        public async Task<bool> IsExist(int id)
        {
            return await complaintRepository.IsExists(id);
        }

        public async Task<ComplaintListResponse> GetComplaintById(int id)
        {
            Complaint complaint = await complaintRepository.GetEntityById(id);
            var response = mapper.Map<ComplaintListResponse>(complaint);
            return response;
        }
    }
}
