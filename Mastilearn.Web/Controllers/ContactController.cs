using Microsoft.AspNetCore.Mvc;
using Mastilearn.Web.Models;

namespace Mastilearn.Web.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet] public IActionResult Index() => View(new ContactRequest());

        [HttpPost]
        public IActionResult Index(ContactRequest model)
        {
            if(!ModelState.IsValid) return View(model);
            TempData["ok"] = "Thanks! We'll get back to you soon.";
            return RedirectToAction(nameof(Sent));
        }

        public IActionResult Sent() => View();
    }
}
