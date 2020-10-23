using ProyectoMVC.Models;
using ProyectoMVC.ServiceReferenceAW;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC.Controllers
{
    public class HumanResources_DepartmentController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: HumanResources_Department
        public ActionResult Index()
        {
            var select = client.SELECT_HumanResources_Departments();
            return View(select);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(HumanResources_DepartmentCLS department)
        {
            client.INSERT_HumanResources_Department_Result(department.Name, department.GroupName, department.ModifiedDate);
            return RedirectToAction("Index");
        }

        public ActionResult Update(Int16 DepartmentID, string GroupName, DateTime ModifiedDate, string Name)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(HumanResources_DepartmentCLS department)
        {
            client.UPDATE_HumanResources_Department_Result(department.DepartmentID, department.Name, department.GroupName, department.ModifiedDate);
            return RedirectToAction("Index");
        }

    }
}