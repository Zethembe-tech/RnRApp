using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLogicDLL.LogicRepo;
using CommonDLL.DTO;
using ReactAPI.Models;

namespace ReactAPI.Controllers
{
    public class BreakdownDTOesController : Controller
    {
        private readonly BreakdownLogic _breakdownLogic = new BreakdownLogic();

        public ActionResult Index()
        {
            var breakdowns = _breakdownLogic.GetAll();
            return View(breakdowns);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BreakdownDTO breakdownDTO = _breakdownLogic.GetDetailsById(id.Value);
            if (breakdownDTO == null)
            {
                return HttpNotFound();
            }
            return View(breakdownDTO);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BreakdownDTO breakdown)
        {
            if (ModelState.IsValid)
            {
                _breakdownLogic.AddBreakdown( breakdown.BreakdownReference, breakdown.CompanyName, breakdown.DriverName,  breakdown.RegistrationNumber, breakdown.BreakdownDate);
                return RedirectToAction("Index");
            }

            return View(breakdown);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BreakdownDTO breakdownDTO = _breakdownLogic.GetDetailsById(id.Value);
            if (breakdownDTO == null)
            {
                return HttpNotFound();
            }
            return View(breakdownDTO);
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BreakdownDTO breakdown)
        {
            if (ModelState.IsValid)
            {
                var breakdowns = _breakdownLogic.EditBreakdown(breakdown.Id, breakdown.BreakdownReference, breakdown.CompanyName, breakdown.DriverName, breakdown.RegistrationNumber, breakdown.BreakdownDate);

                return RedirectToAction("Index");
            }
            return View(breakdown);
        }

        
    }
}
