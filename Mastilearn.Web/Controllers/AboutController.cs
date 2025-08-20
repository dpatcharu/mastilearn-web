using Microsoft.AspNetCore.Mvc;

namespace Mastilearn.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index() => View();
    }
}
