using Microsoft.AspNetCore.Mvc;
using HttpClientCalls.Models;
namespace HttpClientCalls.Controllers
{
    public class ApiController : Controller
    {


        //PostDataModel pObj = new PostDataModel(); 
        //u should use DI here

        PostDataModel _pObj;

        public ApiController(PostDataModel _pObjREF)
        {
            _pObj = _pObjREF;
        }

        public IActionResult PostData()
        {
            ViewBag.post = _pObj.GetPostData();
            return View();
        }
    }
}
