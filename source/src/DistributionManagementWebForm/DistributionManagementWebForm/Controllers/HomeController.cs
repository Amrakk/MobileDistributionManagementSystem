using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DistributionManagementWebForm.Models;

namespace DistributionManagementWebForm.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        MobileDistributionManagementEntities db = new MobileDistributionManagementEntities();
        public ActionResult Index()
        {
            int? id = Session["id"] as int?;
            if (!id.HasValue)
                return RedirectToAction("Login", "User");
            Account account = db.Accounts.Find(id);
            Reseller reseller = db.Resellers.Find(id);
            Profile profile = db.Profiles.Find(id);
            List<Product> products = db.Products.ToList();
            
            ViewBag.Account = account;
            ViewBag.Reseller = reseller;
            ViewBag.Profile = profile;
            ViewBag.Products = products;

            return View();
        }

        
    }
}