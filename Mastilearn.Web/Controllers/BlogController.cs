using Microsoft.AspNetCore.Mvc;

namespace Mastilearn.Web.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Post(string id) => View(); // placeholder
    }
}
