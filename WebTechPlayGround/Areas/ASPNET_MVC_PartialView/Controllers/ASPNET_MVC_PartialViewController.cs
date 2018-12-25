using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTechPlayGround.Areas.ASPNET_MVC_PartialView.Controllers
{
    public class ASPNET_MVC_PartialViewController : Controller
    {
        // GET: ASPNET_MVC_PartialView/ASPNET_MVC_PartialView
        public ActionResult Index()
        {
            return View();
        }

        // GET: ASPNET_MVC_PartialView/ASPNET_MVC_PartialView/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ASPNET_MVC_PartialView/ASPNET_MVC_PartialView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ASPNET_MVC_PartialView/ASPNET_MVC_PartialView/Create
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

        // GET: ASPNET_MVC_PartialView/ASPNET_MVC_PartialView/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ASPNET_MVC_PartialView/ASPNET_MVC_PartialView/Edit/5
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

        // GET: ASPNET_MVC_PartialView/ASPNET_MVC_PartialView/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ASPNET_MVC_PartialView/ASPNET_MVC_PartialView/Delete/5
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
