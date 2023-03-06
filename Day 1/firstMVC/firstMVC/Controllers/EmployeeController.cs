using Microsoft.AspNetCore.Mvc;

namespace firstMVC.Controllers
{
    public class EmployeeController : Controller
    {
       
        public IActionResult EmployeeHome()
        {
            return View();
        }

        public IActionResult EmployeeList()
        {
            //collect data from Model file
            //pass data to view in a ViewBag
            return View();
        }

        public IActionResult SearchEmployee()
        {
            return View();
        }
        public IActionResult AddNewEmployee()
        {
            //collect data from View 
            //pass it to Model
            return View();
        }
    }
}
