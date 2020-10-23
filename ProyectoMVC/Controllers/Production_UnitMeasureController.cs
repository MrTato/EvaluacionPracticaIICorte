using ProyectoMVC.Models;
using ProyectoMVC.ServiceReferenceAW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC.Controllers
{
    public class Production_UnitMeasureController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: Production_UnitMeasure
        public ActionResult Index()
        {
            var select = client.SELECT_Production_UnitMeasure();
            return View(select);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Production_UnitMeasureCLS measure)
        {
            client.INSERT_Production_UnitMeasure_Result(measure.UnitMeasureCode, measure.Name, measure.ModifiedDate);
            return RedirectToAction("Index");
        }

        public ActionResult Update(string UnitMeasureCode, string Name, DateTime ModifiedDate)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(Production_UnitMeasureCLS measure)
        {
            client.UPDATE_Production_UnitMeasure_Result(measure.UnitMeasureCode, measure.Name, measure.ModifiedDate);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string UnitMeasureCode, string Name, DateTime ModifiedDate)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Production_UnitMeasureCLS measure)
        {
            client.DELETE_Production_UnitMeasure_Result(measure.UnitMeasureCode);
            return RedirectToAction("Index");
        }
    }
}