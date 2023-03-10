using Microsoft.AspNetCore.Mvc;

namespace ConsumeWebAPI.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Postdata()
        {
            return View();
        }
    }
}
