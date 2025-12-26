using System.ComponentModel.DataAnnotations;

namespace Product_Catalog_App.Models
{
    public class Product
    {
        [Display(Name = "Ürün Kimliği")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Gerekli bir alan.")]
        [Display(Name = "Kategori Kimliği")]
        public int? CategoryId { get; set; }

        [Required(ErrorMessage = "Gerekli bir alan.")]
        [Display(Name = "Ürün Adı")]
        public string? Name { get; set; }

        
        [Display(Name = "Resim")]
        public string? Image { get; set; }

        [Required(ErrorMessage = "Gerekli bir alan.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat 0'dan büyük olmalıdır.")]
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        public bool IsActive { get; set; }

    }
}
