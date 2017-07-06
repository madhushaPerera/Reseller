using Reseller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reseller.Controllers
{
    public class ResellerController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Reseller
        public ActionResult Index()
        {
            return View(db.ResellerItems.ToList());
        }

        // GET: Reseller/Details/5
        public ActionResult Details(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var reseller = db.ResellerItems.Where(u=>u.ResellerId==id).FirstOrDefault();
                return View(reseller);
            }
                
        }

        // GET: Reseller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reseller/Create
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

        // GET: Reseller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reseller/Edit/5
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

        // GET: Reseller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reseller/Delete/5
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
    }
}
