using ComplaintSystem.Business;
using ComplaintSystem.Entities;
using ComplaintSystem.Web.Models;
using ComplaintSystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IComplaintService complaintservice;

        public HomeController(ILogger<HomeController> logger, IComplaintService complaintService)
        {
            _logger = logger;
            this.complaintservice = complaintService;
        }

        public IActionResult Index()
        {
            var complaints = complaintservice.GetComplaints();
            return View(complaints);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
