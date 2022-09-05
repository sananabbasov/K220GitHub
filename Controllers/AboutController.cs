using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.Controllers
{
    public class AboutController : Controller{

        public IActionResult Index() {
            var name = "Siruz";
            var age = 95;
            age = 99;
            var username = "dolca";
            var surname = "Memmedli";
            return View();
        }

    }
}