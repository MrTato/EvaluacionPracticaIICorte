using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProyectoMVC.Models
{
    public class HumanResources_DepartmentCLS
    {
        [Display(Name = "Department ID")]
        public Int16 DepartmentID { get; set; }
        [Display(Name = "Group name")]
        public string GroupName { get; set; }
        [Display(Name = "Date of last modification")]
        public DateTime ModifiedDate { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}