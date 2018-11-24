using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FAIC.Models
{
    public class Product
    {
        [Key]
        public int  ProductID { get; set; }
        public string ProductName { get; set; }
        public string  SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public string UnitslnStock { get; set; }
        public string  UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }
        public Category Category { get; set; }

    }
}
