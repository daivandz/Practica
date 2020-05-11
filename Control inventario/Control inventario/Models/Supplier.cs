﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Control_inventario.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}