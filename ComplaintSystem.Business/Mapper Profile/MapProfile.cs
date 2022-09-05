using AutoMapper;
using ComplaintSystem.Dtos.Requests;
using ComplaintSystem.Dtos.Responses;
using ComplaintSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Business.Mapper_Profile
{
    public class MapProfile : Profile
    {
        public MapProfile()
       {
            CreateMap<Complaint, ComplaintListResponse>();
            CreateMap<AddComplaintRequest, Complaint>();
       }
            
    }
}
