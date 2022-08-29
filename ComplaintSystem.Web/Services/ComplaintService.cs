using ComplaintSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintSystem.Web.Services
{
    public class ComplaintService
    {
        private List<Complaint> complaints;

        public ComplaintService()
        {
            complaints = new List<Complaint>
            {
            new Complaint {Id = 1, Name = "Apple Sarj", Type = "Telefon"},
            new Complaint { Id = 2, Name = "Siemens Mikrodalga Kapak", Type = "Beyaz Eşya" },
            new Complaint { Id = 3, Name = "Samsung TV Modem", Type = "Televizyon" },
            };
        }
        public List<Complaint> GetComplaints()
        {
            return complaints;
        }
    }
}
