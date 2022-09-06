using ComplaintSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.DataAccess.Repositories
{
    public interface IComplaintRepository : IRepository<Complaint>
    {
        Task<IList<Complaint>> SearchComplaintsByName(string name);
        
    }
}
