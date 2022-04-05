using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Controllers
{
    public class TimeReportController : Controller
    {
        // GET: TimeReportController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TimeReportController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TimeReportController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeReportController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TimeReportController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TimeReportController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TimeReportController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TimeReportController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
