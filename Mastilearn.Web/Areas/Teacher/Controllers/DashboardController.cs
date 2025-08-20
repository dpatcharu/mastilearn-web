using Microsoft.AspNetCore.Mvc;

namespace Mastilearn.Web.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
