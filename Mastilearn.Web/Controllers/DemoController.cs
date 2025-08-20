using Microsoft.AspNetCore.Mvc;
using Mastilearn.Web.Models;

namespace Mastilearn.Web.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet] public IActionResult Index() => View(new DemoRequest());

        [HttpPost]
        public IActionResult Index(DemoRequest model)
        {
            if(!ModelState.IsValid) return View(model);
            TempData["ok"] = "Demo request received!";
            return RedirectToAction(nameof(Booked));
        }

        public IActionResult Booked() => View();
    }
}
