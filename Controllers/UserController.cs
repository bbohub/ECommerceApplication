using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public String Index()
        {
            return "This the first user";
        }
        
        public String TestPathUser()
        {
            return "this is the test of the path of an user";
        }

    }
}
