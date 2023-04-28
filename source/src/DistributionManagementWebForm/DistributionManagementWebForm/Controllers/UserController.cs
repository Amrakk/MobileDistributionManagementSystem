using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DistributionManagementWebForm.Models;
using System.Web.Security;

namespace DistributionManagementWebForm.Controllers
{
    public class UserController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account account)
        {
            using (var db = new MobileDistributionManagementEntities())
            {
                bool isValid = db.Accounts.Any(user => user.username == account.username &&
                                                    user.password == account.password);

                if (isValid)
                {
                    var user = db.Accounts.SingleOrDefault(u => u.username == account.username);
                    Reseller reseller = db.Resellers.Find(user.account_id);
                    if (reseller == null)
                    {
                        ModelState.AddModelError("", "Resellers only!");
                        return View();
                    }
                    FormsAuthentication.SetAuthCookie(reseller.reseller_name, false);
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid username or password");
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }


    }
}
