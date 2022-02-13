using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class EmployeeModel
    {
        public string Status { get; set; }
        [Display(ResourceType = typeof(Resources.MVC), Name = "FName")]
        public string Fname { get; set; }
        [Display(ResourceType = typeof(Resources.MVC), Name = "LName")]
        public string LName { get; set; }

        public string Name => this.Fname + " " + this.LName;

    }
}