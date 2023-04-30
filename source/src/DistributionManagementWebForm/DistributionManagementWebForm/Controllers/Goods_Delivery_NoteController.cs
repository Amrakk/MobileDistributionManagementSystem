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
    public class Goods_Delivery_NoteController : Controller
    {
        private MobileDistributionManagementEntities db = new MobileDistributionManagementEntities();

        // GET: Goods_Delivery_Note
        public ActionResult Index()
        {
            var goods_Delivery_Note = db.Goods_Delivery_Note.Include(g => g.Order_Note);
            return View(goods_Delivery_Note.ToList());
        }

        // GET: Goods_Delivery_Note/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Goods_Delivery_Note goods_Delivery_Note = db.Goods_Delivery_Note.Find(id);
            if (goods_Delivery_Note == null)
            {
                return HttpNotFound();
            }
            return View(goods_Delivery_Note);
        }

        // GET: Goods_Delivery_Note/Create
        public ActionResult Create()
        {
            ViewBag.delivery_id = new SelectList(db.Order_Note, "order_id", "payment_method");
            return View();
        }

        // POST: Goods_Delivery_Note/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "delivery_id,delivery_date,delivery_method")] Goods_Delivery_Note goods_Delivery_Note)
        {
            if (ModelState.IsValid)
            {
                db.Goods_Delivery_Note.Add(goods_Delivery_Note);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.delivery_id = new SelectList(db.Order_Note, "order_id", "payment_method", goods_Delivery_Note.delivery_id);
            return View(goods_Delivery_Note);
        }

        // GET: Goods_Delivery_Note/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Goods_Delivery_Note goods_Delivery_Note = db.Goods_Delivery_Note.Find(id);
            if (goods_Delivery_Note == null)
            {
                return HttpNotFound();
            }
            ViewBag.delivery_id = new SelectList(db.Order_Note, "order_id", "payment_method", goods_Delivery_Note.delivery_id);
            return View(goods_Delivery_Note);
        }

        // POST: Goods_Delivery_Note/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "delivery_id,delivery_date,delivery_method")] Goods_Delivery_Note goods_Delivery_Note)
        {
            if (ModelState.IsValid)
            {
                db.Entry(goods_Delivery_Note).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.delivery_id = new SelectList(db.Order_Note, "order_id", "payment_method", goods_Delivery_Note.delivery_id);
            return View(goods_Delivery_Note);
        }

        // GET: Goods_Delivery_Note/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Goods_Delivery_Note goods_Delivery_Note = db.Goods_Delivery_Note.Find(id);
            if (goods_Delivery_Note == null)
            {
                return HttpNotFound();
            }
            return View(goods_Delivery_Note);
        }

        // POST: Goods_Delivery_Note/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Goods_Delivery_Note goods_Delivery_Note = db.Goods_Delivery_Note.Find(id);
            db.Goods_Delivery_Note.Remove(goods_Delivery_Note);
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
