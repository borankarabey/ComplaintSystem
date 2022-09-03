using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Complaint> Complaints { get; set; }

    }
}
