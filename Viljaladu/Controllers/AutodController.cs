using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Viljaladu.DAL;
using Viljaladu.Models;

namespace Viljaladu.Controllers
{
    public class AutodController : Controller
    {
		private AutoContext db = new AutoContext();

        // GET: SisenevadAutod
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult LisaSisenevAuto()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult LisaSisenevAuto([Bind(Include = "Id, sisenemisMass, autoNr")] Auto auto)
		{
			if (ModelState.IsValid)
			{
				db.Autod.Add(auto);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}

		public ActionResult valiLaosAuto()
		{
			var model = db.Autod
				.Where(u => u.lahkumisMass == 0)
				.ToList();
			return View(model);
		}


		public ActionResult PaneLahkumisMass(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Auto auto = db.Autod.Find(id);
			if (auto == null)
			{
				return HttpNotFound();
			}
			return View(auto);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult PaneLahkumisMass([Bind(Include = "Id, lahkumisMass")] Auto auto)
		{
			if (ModelState.IsValid)
			{
				db.Entry(auto).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("valiLaosAuto");
			}
			return View();
		}

		// GET: SisenevadAutod/Details/5
		public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SisenevadAutod/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SisenevadAutod/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SisenevadAutod/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SisenevadAutod/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SisenevadAutod/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SisenevadAutod/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

		protected override void Dispose(bool disposing)
		{
			if(disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
