using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.Controllers
{
    public class AboutController : Controller{

        public IActionResult Index() {
            var name = "Siruz";
            var age = 95;
            return View();
        }

    }
}