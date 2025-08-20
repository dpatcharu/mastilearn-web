using Microsoft.AspNetCore.Mvc;

namespace Mastilearn.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login() => View();
        public IActionResult Register() => View();
    }
}
