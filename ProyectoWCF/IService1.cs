using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProyectoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        void DELETE_HumanResources_Department_Result(Int16 DepartamentoID);
        [OperationContract]
        void DELETE_Production_ProductCategory_Result(Int32 productCategoryID);
        [OperationContract]
        void DELETE_Production_UnitMeasure_Result(string unitMeasureCode);
        [OperationContract]
        void INSERT_HumanResources_Department_Result(string name, string groupName, DateTime modifiedDate);
        [OperationContract]
        void INSERT_Production_ProductCategory_Result(string name, DateTime modifiedDate);
        [OperationContract]
        void INSERT_Production_UnitMeasure_Result(string unitMeasureCode, string name, DateTime modifiedDate);
        [OperationContract]
        List<SELECT_HumanResources_Department_Result> SELECT_HumanResources_Departments();
        [OperationContract]
        List<SELECT_Production_ProductCategory_Result> SELECT_Production_ProductCategory();
        [OperationContract]
        List<SELECT_Production_UnitMeasure_Result> SELECT_Production_UnitMeasure();
        [OperationContract]
        void UPDATE_HumanResources_Department_Result(short departmentID, string name, string groupName, DateTime modifiedDate);
        [OperationContract]
        void UPDATE_Production_ProductCategory_Result(int productCategoryID, string name, DateTime modifiedDate);
        [OperationContract]
        void UPDATE_Production_UnitMeasure_Result(string unitMeasureCode, string name, DateTime modifiedDate);
    }

}
