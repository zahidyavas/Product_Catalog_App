using System.ComponentModel.DataAnnotations;

namespace Product_Catalog_App.Models
{
    public class Product
    {
        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Ürün Adı")]
        public string? Name { get; set; }
        [Display(Name = "Görsel")]
        public string? Image { get; set; }
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
