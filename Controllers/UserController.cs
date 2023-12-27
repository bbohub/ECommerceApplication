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
        
        public String DetailsUser()
        {
            return "this is the details of an user";
        }

    }
}
