using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Entity.Models
{
    public class DepartmentTotals
    {
        public string Name { get; set; }
        public int Total { get; set; }
    }
}