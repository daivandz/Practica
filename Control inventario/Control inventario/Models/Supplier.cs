using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Control_inventario.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Display(Name = "Codigo Proveedor")]//Data Annotation
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}