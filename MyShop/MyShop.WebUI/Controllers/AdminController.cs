using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.WebUI.Controllers
{
    [Authorize(Roles ="ADMIN")]
    //[Authorize(Users = "DarkRock@gmail.com")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}