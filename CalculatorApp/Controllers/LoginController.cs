using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("loginform");
        }
        [HttpPost]
        public ActionResult Loginform(FormCollection collection)
        {
            string email = collection.Get("email");
            string Password = collection.Get("Password");
            if (email == "admin@infosys.com" && Password == "admin")
            {
                Response.Redirect("http://localhost:80/Home/Index");
            }
            else
            {
                ViewBag.Message = "Please enter valid Email ID and Password";

            }
            return View("Index");
        }
        }
}