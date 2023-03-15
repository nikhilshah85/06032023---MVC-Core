using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bankingMVC_oAuth.Controllers
{

    [Authorize]
    public class BankingController : Controller
    {

        [AllowAnonymous]
        public IActionResult BankingHome()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Services()
        {
            return View();
        }
        //user should be logged in
        public IActionResult DownloadStatement()
        {
            return View();
        }
        //user should be logged in
        public IActionResult TransferFunds()
        {
            return View();
        }
    }
}
