using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NotesMarketplace.Controllers
{
    public class HomeController : Controller
   {
        private Models.NotesMarketplaceEntities db = new Models.NotesMarketplaceEntities();
        public ActionResult SignUp()
        {
            return View();
            
        }

        [HttpPost]
        public ActionResult SignUp(Models.User user)
        {
            try
            {
                user.IsActive = true;
                user.IsDetailsSubmitted = false;
                user.IsActive = true;
                user.F_K_UserRoles = 1;

                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login", "HomeController");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }
        
    }
}