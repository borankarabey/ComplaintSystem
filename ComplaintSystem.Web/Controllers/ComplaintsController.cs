using ComplaintSystem.Business;
using ComplaintSystem.Dtos.Requests;
using ComplaintSystem.Entities;
using ComplaintSystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
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

        [HttpGet]
        public IActionResult Create()
        {
            var selectedItems = new List<SelectListItem>();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddComplaintRequest request)
        {
            if (ModelState.IsValid)
            {
                int addedComplaintId = await complaintService.AddComplaint(request);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
