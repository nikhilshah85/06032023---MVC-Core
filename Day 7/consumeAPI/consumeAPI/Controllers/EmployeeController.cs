using Microsoft.AspNetCore.Mvc;

namespace consumeAPI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
