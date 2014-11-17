using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marcos.Views.MARCOS
{
    public class MARCOSController : Controller
    {
        // GET: Index View
        public ActionResult Index()
        {
            return View();
        }

        // GET: MARCOSHome View
        public ActionResult MARCOSHome()
        {
            return View();
        }

        // GET: Questions View
        public ActionResult Questions()
        {
            return View();
        }

        // GET: Search View
        public ActionResult Search()
        {
            return View();
        }

        // GET: Viewquestions view
        public ActionResult ViewQuestions()
        {
            return View();
        }

        // GET: PostQuestions View
        public ActionResult PostQuestions()
        {
            return View();
        }

        // GET: MARCOS/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MARCOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MARCOS/Create
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

        // GET: MARCOS/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MARCOS/Edit/5
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

        // GET: MARCOS/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MARCOS/Delete/5
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
