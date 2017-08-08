using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using M3PMVC.PartyModels;
using M3PMVC.Models;

namespace M3PMVC.Controllers
{
    public class PartyVisaController : Controller
    {
        private PartyDBContext db = new PartyDBContext();

        //
        // GET: /PartyVisa/

        public ActionResult Index()
        {
            return View(db.PVisas.ToList());
        }

        //
        // GET: /PartyVisa/Details/5

        public ActionResult Details(int id = 0)
        {
            PartyVisa partyvisa = db.PVisas.Find(id);
            if (partyvisa == null)
            {
                return HttpNotFound();
            }
            return View(partyvisa);
        }

        //
        // GET: /PartyVisa/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PartyVisa/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PartyVisa partyvisa)
        {
            if (ModelState.IsValid)
            {
                db.PVisas.Add(partyvisa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(partyvisa);
        }

        //
        // GET: /PartyVisa/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PartyVisa partyvisa = db.PVisas.Find(id);
            if (partyvisa == null)
            {
                return HttpNotFound();
            }
            return View(partyvisa);
        }

        //
        // POST: /PartyVisa/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PartyVisa partyvisa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partyvisa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(partyvisa);
        }

        //
        // GET: /PartyVisa/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PartyVisa partyvisa = db.PVisas.Find(id);
            if (partyvisa == null)
            {
                return HttpNotFound();
            }
            return View(partyvisa);
        }

        //
        // POST: /PartyVisa/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PartyVisa partyvisa = db.PVisas.Find(id);
            db.PVisas.Remove(partyvisa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}