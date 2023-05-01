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
    public class Order_ItemController : Controller
    {
        private MobileDistributionManagementEntities db = new MobileDistributionManagementEntities();

        // GET: Order_Item
        public ActionResult Index()
        {
            var order_Item = db.Order_Item.Include(o => o.Order_Note).Include(o => o.Product);
            return View(order_Item.ToList());
        }

        // GET: Order_Item/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Item order_Item = db.Order_Item.Find(id);
            if (order_Item == null)
            {
                return HttpNotFound();
            }
            return View(order_Item);
        }

        // GET: Order_Item/Create
        public ActionResult Create()
        {
            ViewBag.order_id = new SelectList(db.Order_Note, "order_id", "payment_method");
            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name");
            return View();
        }

        // POST: Order_Item/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "order_id,product_id,quantity")] Order_Item order_Item)
        {
            if (ModelState.IsValid)
            {
                db.Order_Item.Add(order_Item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.order_id = new SelectList(db.Order_Note, "order_id", "payment_method", order_Item.order_id);
            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name", order_Item.product_id);
            return View(order_Item);
        }

        // GET: Order_Item/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Item order_Item = db.Order_Item.Find(id);
            if (order_Item == null)
            {
                return HttpNotFound();
            }
            ViewBag.order_id = new SelectList(db.Order_Note, "order_id", "payment_method", order_Item.order_id);
            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name", order_Item.product_id);
            return View(order_Item);
        }

        // POST: Order_Item/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "order_id,product_id,quantity")] Order_Item order_Item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order_Item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.order_id = new SelectList(db.Order_Note, "order_id", "payment_method", order_Item.order_id);
            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name", order_Item.product_id);
            return View(order_Item);
        }

        // GET: Order_Item/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Item order_Item = db.Order_Item.Find(id);
            if (order_Item == null)
            {
                return HttpNotFound();
            }
            return View(order_Item);
        }

        // POST: Order_Item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order_Item order_Item = db.Order_Item.Find(id);
            db.Order_Item.Remove(order_Item);
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
