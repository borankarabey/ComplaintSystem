﻿using ComplaintSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Business
{
    public interface IComplaintService
    {
        Task <ICollection<Complaint>> GetComplaints();

    }
}
