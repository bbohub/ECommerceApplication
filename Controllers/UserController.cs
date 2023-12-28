using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ECommerceApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult DetailsUser(String name)
        {
            ViewData["Message"] = "Hello " + name;
            return View();
        }

    }
}
