using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            this.feedbackRepository = feedbackRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackRepository.AddFeedBack(feedback);
                return RedirectToAction("FeedbackComplete");
            }

            return View(feedback);
        }
        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}
