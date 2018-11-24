using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FAIC.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string  CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public List<Product> Product { get; set; }
    }
}
