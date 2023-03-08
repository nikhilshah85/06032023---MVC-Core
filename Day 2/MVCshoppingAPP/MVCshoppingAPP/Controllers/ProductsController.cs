using Microsoft.AspNetCore.Mvc;
using MVCshoppingAPP.Models;
namespace MVCshoppingAPP.Controllers
{
    public class ProductsController : Controller
    {

        ProductsModel pObj = new ProductsModel(); //this is a bad code, we should use DI instead

        public IActionResult ProductList()
        {

            ViewBag.products = pObj.GetAllProducts();
            return View();
        }


        //get the page first, display textbox and a button
        public IActionResult SearchProduct()
        {
            ViewBag.isSearchPerformed = false;

            return View();
        }

        [HttpPost]
        public IActionResult SearchProduct(int id)
        {
            try
            {
                ViewBag.product = pObj.SearchById(id);

                ViewBag.isSearchPerformed = true;
                return View();
            }
            catch (Exception es)
            {
                ViewBag.isSearchPerformed = false;
                ViewBag.errMessage = es.Message;
                return View();
            }
           
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductsModel newP)
        {
            ViewBag.addResult = pObj.AddNewProduct(newP);
            return RedirectToAction("ProductList");
                
        }
    }
}






