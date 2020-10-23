using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoMVC.Models
{
    public class Production_ProductCategoryCLS
    {
        [Display(Name = "Date of last modification")]
        public DateTime ModifiedDate { get; set; }
        [Display(Name = "Product name")]
        public string Name { get; set; }
        [Display (Name="Product Category ID")]
        public Int32 ProductCategoryID { get; set; }
    }
}