using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StopSagi.Models;

namespace StopSagi.Controllers
{
    public class BlackListController : Controller
    {
        private stopsagiEntities db = new stopsagiEntities();
        

        //
        // GET: /BlackList/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BlackList/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(blackList blacklist)
        {
            if (ModelState.IsValid)
            {
                blacklist.id = Guid.NewGuid();
                blacklist.ins_date = DateTime.Now;
                blacklist.upd_date = DateTime.Now;

                db.blackList.Add(blacklist);
                db.SaveChanges();
                return RedirectToAction("Address","Default",blacklist);
            }

            return View(blacklist);
        }

        //
        // GET: /BlackList/Edit/5

        public ActionResult Edit(Guid id = default(Guid))
        {
            blackList blacklist = db.blackList.Find(id);
            if (blacklist == null)
            {
                return HttpNotFound();
            }
            return View(blacklist);
        }

        //
        // POST: /BlackList/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(blackList blacklist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blacklist).State = EntityState.Modified;
                blacklist.upd_date = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Address", "Default", null);
            }
            return View(blacklist);
        }

        //
        // GET: /BlackList/Delete/5

        public ActionResult Delete(Guid id = default(Guid))
        {
            blackList blacklist = db.blackList.Find(id);
            if (blacklist == null)
            {
                return HttpNotFound();
            }
            return View(blacklist);
        }

        //
        // POST: /BlackList/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            blackList blacklist = db.blackList.Find(id);
            db.blackList.Remove(blacklist);
            db.SaveChanges();
            return RedirectToAction("Address", "Default", null);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}