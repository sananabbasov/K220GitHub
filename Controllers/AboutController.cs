using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.Controllers
{
    public class AboutController : Controller{

        public IActionResult About() {

            return View();
        }

    }
}