using ProyectoMVC.Models;
using ProyectoMVC.ServiceReferenceAW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC.Controllers
{
    public class Production_ProductCategoryController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: Production_ProductCategory
        public ActionResult Index()
        {
            var select = client.SELECT_Production_ProductCategory();
            return View(select);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Production_ProductCategoryCLS category)
        {
            client.INSERT_Production_ProductCategory_Result(category.Name, category.ModifiedDate);
            return RedirectToAction("Index");
        }
        public ActionResult Update(int ProductCategoryID, string Name, DateTime ModifiedDate)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(Production_ProductCategoryCLS category)
        {
            client.UPDATE_Production_ProductCategory_Result(category.ProductCategoryID, category.Name, category.ModifiedDate);
            return RedirectToAction("Index");
        }
    }
}