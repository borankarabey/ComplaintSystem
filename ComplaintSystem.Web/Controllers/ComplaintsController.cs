using ComplaintSystem.Business;
using ComplaintSystem.Dtos.Requests;
using ComplaintSystem.Dtos.Responses;
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
        private readonly IComplaintService complaintService;

        public ComplaintsController(IComplaintService complaintService)
        {
            this.complaintService = complaintService;
        }
        public async Task<IActionResult> Index()
        {
            var complaints = complaintService.GetComplaints();
            return View(complaints);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var selectedItems = new List<SelectListItem>();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name", "Type")] AddComplaintRequest request)
        {
            if (ModelState.IsValid)
            {
                int addedProductId = await complaintService.AddComplaint(request);
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (await complaintService.IsExist(id))
            {
                ComplaintListResponse response = await complaintService.GetComplaintById(id);

                return View(response);
            }

            return NotFound();
        }
    }
}
