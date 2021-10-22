using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class AccountController : Controller
    {
        
        [HttpGet]
        // GET: Account
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl) 
        {
            IAuthProvider authProvider = new FormsAuthProvider();

            if (ModelState.IsValid)
            {
                if (authProvider.Authenticate(model.UserName, model.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "Nieprawidłowa nazwa użytkownka lub nieproawidłowe hasło");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}