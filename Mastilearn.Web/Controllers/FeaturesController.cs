using Microsoft.AspNetCore.Mvc;

namespace Mastilearn.Web.Controllers
{
    public class FeaturesController : Controller
    {
        public IActionResult Index() => View(); // Tabs: Students / Teachers / Schools
    }
}
