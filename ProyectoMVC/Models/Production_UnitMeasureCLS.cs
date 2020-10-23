using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoMVC.Models
{
    public class Production_UnitMeasureCLS
    {
        [Display (Name="Date of last modification")]
        public DateTime ModifiedDate { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Unit of Measurement Code")]
        public string UnitMeasureCode { get; set; }
    }
}