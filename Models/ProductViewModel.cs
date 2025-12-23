using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Catalog_App.Models
{
    public class ProductViewModel
    {
        public List<Product>? Products { get; set; }
        public List<Category>? Categories { get; set; }
        public string? SelectedCategory { get; set; }
    }
}