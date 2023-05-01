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
    public class Order_NoteController : Controller
    {
        private MobileDistributionManagementEntities db = new MobileDistributionManagementEntities();

        // GET: Order_Note
        public ActionResult Index()
        {
            var order_Note = db.Order_Note.Include(o => o.Delivery_Note).Include(o => o.Order_Item).Include(o => o.Reseller).Include(o => o.Status);
            return View(order_Note.ToList());
        }

        // GET: Order_Note/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Note order_Note = db.Order_Note.Find(id);
            if (order_Note == null)
            {
                return HttpNotFound();
            }
            return View(order_Note);
        }

        // GET: Order_Note/Create
        public ActionResult Create()
        {
            ViewBag.order_id = new SelectList(db.Delivery_Note, "delivery_id", "delivery_method");
            ViewBag.order_id = new SelectList(db.Order_Item, "order_id", "order_id");
            ViewBag.reseller_id = new SelectList(db.Resellers, "reseller_id", "reseller_name");
            ViewBag.status_id = new SelectList(db.Status, "status_id", "status_name");
            return View();
        }

        // POST: Order_Note/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "order_id,order_date,reseller_id,status_id,total_price,payment_method")] Order_Note order_Note)
        {
            if (ModelState.IsValid)
            {
                db.Order_Note.Add(order_Note);
                db.SaveChanges();
                return Json(new { order_id = order_Note.order_id });
            }

            ViewBag.order_id = new SelectList(db.Delivery_Note, "delivery_id", "delivery_method", order_Note.order_id);
            ViewBag.order_id = new SelectList(db.Order_Item, "order_id", "order_id", order_Note.order_id);
            ViewBag.reseller_id = new SelectList(db.Resellers, "reseller_id", "reseller_name", order_Note.reseller_id);
            ViewBag.status_id = new SelectList(db.Status, "status_id", "status_name", order_Note.status_id);
            return View(order_Note);
        }

        // GET: Order_Note/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Note order_Note = db.Order_Note.Find(id);
            if (order_Note == null)
            {
                return HttpNotFound();
            }
            ViewBag.order_id = new SelectList(db.Delivery_Note, "delivery_id", "delivery_method", order_Note.order_id);
            ViewBag.order_id = new SelectList(db.Order_Item, "order_id", "order_id", order_Note.order_id);
            ViewBag.reseller_id = new SelectList(db.Resellers, "reseller_id", "reseller_name", order_Note.reseller_id);
            ViewBag.status_id = new SelectList(db.Status, "status_id", "status_name", order_Note.status_id);
            return View(order_Note);
        }

        // POST: Order_Note/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "order_id,order_date,reseller_id,status_id,total_price,payment_method")] Order_Note order_Note)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order_Note).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.order_id = new SelectList(db.Delivery_Note, "delivery_id", "delivery_method", order_Note.order_id);
            ViewBag.order_id = new SelectList(db.Order_Item, "order_id", "order_id", order_Note.order_id);
            ViewBag.reseller_id = new SelectList(db.Resellers, "reseller_id", "reseller_name", order_Note.reseller_id);
            ViewBag.status_id = new SelectList(db.Status, "status_id", "status_name", order_Note.status_id);
            return View(order_Note);
        }

        // GET: Order_Note/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Note order_Note = db.Order_Note.Find(id);
            if (order_Note == null)
            {
                return HttpNotFound();
            }
            return View(order_Note);
        }

        // POST: Order_Note/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order_Note order_Note = db.Order_Note.Find(id);
            db.Order_Note.Remove(order_Note);
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
