using ComplaintSystem.Business;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ComplaintSystem.Web.Controllers
{
    public class ComplaintsController : Controller
    {
        private readonly IComplaintService complaintservice;

        public ComplaintsController(IComplaintService complaintService)
        {
            this.complaintservice = complaintService;
        }
        public async Task<IActionResult> Index()
        {
            var complaints = complaintservice.GetComplaints();
            return View(complaints);
        }
    }
}
