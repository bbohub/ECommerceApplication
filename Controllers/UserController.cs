using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public IActionResult Index()
        {
            return View();
        }
        
        public String DetailsUser()
        {
            return "this is the details of an user";
        }

    }
}
