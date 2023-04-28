using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DistributionManagementWebForm.Models;

namespace DistributionManagementWebForm.Controllers
{
    public class ProfilesController : Controller
    {
        private MobileDistributionManagementEntities db = new MobileDistributionManagementEntities();

        // GET: Profiles
        public ActionResult Index()
        {
            var profiles = db.Profiles.Include(p => p.Account).Include(p => p.Role).Include(p => p.Reseller);
            return View(profiles.ToList());
        }

        // GET: Profiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        // GET: Profiles/Create
        public ActionResult Create()
        {
            ViewBag.profile_id = new SelectList(db.Accounts, "account_id", "username");
            ViewBag.role_id = new SelectList(db.Roles, "role_id", "role_name");
            ViewBag.profile_id = new SelectList(db.Resellers, "reseller_id", "reseller_name");
            return View();
        }

        // POST: Profiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "profile_id,first_name,last_name,email,phone,role_id")] Profile profile)
        {
            if (ModelState.IsValid)
            {
                db.Profiles.Add(profile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.profile_id = new SelectList(db.Accounts, "account_id", "username", profile.profile_id);
            ViewBag.role_id = new SelectList(db.Roles, "role_id", "role_name", profile.role_id);
            ViewBag.profile_id = new SelectList(db.Resellers, "reseller_id", "reseller_name", profile.profile_id);
            return View(profile);
        }

        // GET: Profiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            ViewBag.profile_id = new SelectList(db.Accounts, "account_id", "username", profile.profile_id);
            ViewBag.role_id = new SelectList(db.Roles, "role_id", "role_name", profile.role_id);
            ViewBag.profile_id = new SelectList(db.Resellers, "reseller_id", "reseller_name", profile.profile_id);
            return View(profile);
        }

        // POST: Profiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "profile_id,first_name,last_name,email,phone,role_id")] Profile profile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.profile_id = new SelectList(db.Accounts, "account_id", "username", profile.profile_id);
            ViewBag.role_id = new SelectList(db.Roles, "role_id", "role_name", profile.role_id);
            ViewBag.profile_id = new SelectList(db.Resellers, "reseller_id", "reseller_name", profile.profile_id);
            return View(profile);
        }

        // GET: Profiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        // POST: Profiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profile profile = db.Profiles.Find(id);
            db.Profiles.Remove(profile);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
