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
    public class ResellersController : Controller
    {
        private MobileDistributionManagementEntities db = new MobileDistributionManagementEntities();

        // GET: Resellers
        public ActionResult Index()
        {
            var resellers = db.Resellers.Include(r => r.Profile);
            return View(resellers.ToList());
        }

        // GET: Resellers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reseller reseller = db.Resellers.Find(id);
            if (reseller == null)
            {
                return HttpNotFound();
            }
            return View(reseller);
        }

        // GET: Resellers/Create
        public ActionResult Create()
        {
            ViewBag.reseller_id = new SelectList(db.Profiles, "profile_id", "first_name");
            return View();
        }

        // POST: Resellers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "reseller_id,reseller_name,address")] Reseller reseller)
        {
            if (ModelState.IsValid)
            {
                db.Resellers.Add(reseller);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.reseller_id = new SelectList(db.Profiles, "profile_id", "first_name", reseller.reseller_id);
            return View(reseller);
        }

        // GET: Resellers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reseller reseller = db.Resellers.Find(id);
            if (reseller == null)
            {
                return HttpNotFound();
            }
            ViewBag.reseller_id = new SelectList(db.Profiles, "profile_id", "first_name", reseller.reseller_id);
            return View(reseller);
        }

        // POST: Resellers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "reseller_id,reseller_name,address")] Reseller reseller)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reseller).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.reseller_id = new SelectList(db.Profiles, "profile_id", "first_name", reseller.reseller_id);
            return View(reseller);
        }

        // GET: Resellers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reseller reseller = db.Resellers.Find(id);
            if (reseller == null)
            {
                return HttpNotFound();
            }
            return View(reseller);
        }

        // POST: Resellers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reseller reseller = db.Resellers.Find(id);
            db.Resellers.Remove(reseller);
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
