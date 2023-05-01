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
    public class Delivery_NoteController : Controller
    {
        private MobileDistributionManagementEntities db = new MobileDistributionManagementEntities();

        // GET: Delivery_Note
        public ActionResult Index()
        {
            var delivery_Note = db.Delivery_Note.Include(d => d.Order_Note);
            return View(delivery_Note.ToList());
        }

        // GET: Delivery_Note/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Delivery_Note delivery_Note = db.Delivery_Note.Find(id);
            if (delivery_Note == null)
            {
                return HttpNotFound();
            }
            return View(delivery_Note);
        }

        // GET: Delivery_Note/Create
        public ActionResult Create()
        {
            ViewBag.delivery_id = new SelectList(db.Order_Note, "order_id", "payment_method");
            return View();
        }

        // POST: Delivery_Note/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "delivery_id,delivery_date,delivery_method")] Delivery_Note delivery_Note)
        {
            if (ModelState.IsValid)
            {
                db.Delivery_Note.Add(delivery_Note);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.delivery_id = new SelectList(db.Order_Note, "order_id", "payment_method", delivery_Note.delivery_id);
            return View(delivery_Note);
        }

        // GET: Delivery_Note/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Delivery_Note delivery_Note = db.Delivery_Note.Find(id);
            if (delivery_Note == null)
            {
                return HttpNotFound();
            }
            ViewBag.delivery_id = new SelectList(db.Order_Note, "order_id", "payment_method", delivery_Note.delivery_id);
            return View(delivery_Note);
        }

        // POST: Delivery_Note/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "delivery_id,delivery_date,delivery_method")] Delivery_Note delivery_Note)
        {
            if (ModelState.IsValid)
            {
                db.Entry(delivery_Note).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.delivery_id = new SelectList(db.Order_Note, "order_id", "payment_method", delivery_Note.delivery_id);
            return View(delivery_Note);
        }

        // GET: Delivery_Note/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Delivery_Note delivery_Note = db.Delivery_Note.Find(id);
            if (delivery_Note == null)
            {
                return HttpNotFound();
            }
            return View(delivery_Note);
        }

        // POST: Delivery_Note/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Delivery_Note delivery_Note = db.Delivery_Note.Find(id);
            db.Delivery_Note.Remove(delivery_Note);
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
