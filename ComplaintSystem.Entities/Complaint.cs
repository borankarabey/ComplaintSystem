using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Entities
{
    public class Complaint : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "ID of the complaint can't be Empty!")]
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Info { get; set; }
        public ICollection<Complaint> Complaints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
