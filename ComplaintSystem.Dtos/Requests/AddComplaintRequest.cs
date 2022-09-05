using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Dtos.Requests
{
    public class AddComplaintRequest
    {
        [Required(ErrorMessage = "Name of the complaint can't be Empty!")]
        [MinLength(3,ErrorMessage = "Name must be at least 3 characters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type of the complaint can't be Empty!")]
        public string Type { get; set; }
    }
}
