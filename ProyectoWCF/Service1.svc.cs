using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProyectoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        AdventureWorks2019Entities db = new AdventureWorks2019Entities();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        // TODO: Publicar el resto de metodos que requieren entrada del usuario

        public void DELETE_HumanResources_Department_Result(Int16 DepartamentoID)
        {
            db.DELETE_HumanResources_Department_Result(DepartamentoID);
        }
        public void DELETE_Production_ProductCategory_Result(Int32 productCategoryID)
        {
            db.DELETE_Production_ProductCategory_Result(productCategoryID);
        }
        public void DELETE_Production_UnitMeasure_Result(string unitMeasureCode)
        {
            db.DELETE_Production_UnitMeasure_Result(unitMeasureCode);
        }
        public void INSERT_HumanResources_Department_Result(string name, string groupName, DateTime modifiedDate)
        {
            db.INSERT_HumanResources_Department_Result(name, groupName, modifiedDate);
        }
        public void INSERT_Production_ProductCategory_Result(string name, DateTime modifiedDate)
        {
            db.INSERT_Production_ProductCategory_Result(name, modifiedDate);
        }
        public void INSERT_Production_UnitMeasure_Result(string unitMeasureCode, string name, DateTime modifiedDate)
        {
            db.INSERT_Production_UnitMeasure_Result(unitMeasureCode, name, modifiedDate);
        }
        public List<SELECT_HumanResources_Department_Result> SELECT_HumanResources_Departments()
        {
            return db.SELECT_HumanResources_Department_Result().ToList();
        }
        public List<SELECT_Production_ProductCategory_Result> SELECT_Production_ProductCategory()
        {
            return db.SELECT_Production_ProductCategory_Result().ToList();
        }
        public List<SELECT_Production_UnitMeasure_Result> SELECT_Production_UnitMeasure()
        {
            return db.SELECT_Production_UnitMeasure_Result().ToList();
        }
        public void UPDATE_HumanResources_Department_Result(short departmentID, string name, string groupName, DateTime modifiedDate)
        {
            db.UPDATE_HumanResources_Department_Result(departmentID, name, groupName, modifiedDate);
        }
        public void UPDATE_Production_ProductCategory_Result(int productCategoryID, string name, DateTime modifiedDate)
        {
            db.UPDATE_Production_ProductCategory_Result(productCategoryID, name, modifiedDate);
        }
        public void UPDATE_Production_UnitMeasure_Result(string unitMeasureCode, string name, DateTime modifiedDate)
        {
            db.UPDATE_Production_UnitMeasure_Result(unitMeasureCode, name, modifiedDate);
        }
    }
}
