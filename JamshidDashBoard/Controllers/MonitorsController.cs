using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JamshidDashBoard.Models;

namespace JamshidDashBoard.Controllers
{
    public class MonitorsController : Controller
    {
        private MeasurementContext db = new MeasurementContext();

        // GET: Monitors
        public ActionResult Index()
        {
            return View(db.Monitors.ToList());
        }

        // GET: Monitors/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitor monitor = db.Monitors.Find(id);
            if (monitor == null)
            {
                return HttpNotFound();
            }
            return View(monitor);
        }

        // GET: Monitors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Monitors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MonitorID,PersonName,PersonalPageUrl")] Monitor monitor)
        {
            if (ModelState.IsValid)
            {
                db.Monitors.Add(monitor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(monitor);
        }

        // GET: Monitors/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitor monitor = db.Monitors.Find(id);
            if (monitor == null)
            {
                return HttpNotFound();
            }
            return View(monitor);
        }

        // POST: Monitors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MonitorID,PersonName,PersonalPageUrl")] Monitor monitor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monitor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(monitor);
        }

        // GET: Monitors/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitor monitor = db.Monitors.Find(id);
            if (monitor == null)
            {
                return HttpNotFound();
            }
            return View(monitor);
        }

        // POST: Monitors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Monitor monitor = db.Monitors.Find(id);
            db.Monitors.Remove(monitor);
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
