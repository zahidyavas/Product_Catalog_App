namespace Product_Catalog_App.Models
{
    public class Repository
    {
        // Fake Database

        private static List<Product> _products = new();
        public static List<Product> Products
        {
            get { return _products; }
        }

        private static List<Category> _categories = new();
        public static List<Category> Categories
        {
            get { return _categories; }
        }

        static Repository() // Static constructor was created to initialize data
        {
            _categories.Add(new Category { CategoryId = 1, Name = "iPhone" });
            _categories.Add(new Category { CategoryId = 2, Name = "Macbook" });

            _products.Add(new Product { ProductId = 1, CategoryId = 1, Name = "iPhone 15", Image = "iphone_15.jpg", Price = 29999, IsActive = true });
            _products.Add(new Product { ProductId = 2, CategoryId = 1, Name = "iPhone 16", Image = "iphone_16.jpg", Price = 39999, IsActive = true });
            _products.Add(new Product { ProductId = 3, CategoryId = 1, Name = "iPhone 17 Air", Image = "iphone_17_air.jpg", Price = 79999, IsActive = true });
            _products.Add(new Product { ProductId = 4, CategoryId = 1, Name = "iPhone 17 Pro Max", Image = "iphone_17_pro_max.jpg", Price = 149999, IsActive = true });
            _products.Add(new Product { ProductId = 5, CategoryId = 2, Name = "Macbook Air", Image = "macbook_air.jpg", Price = 89999, IsActive = true });
            _products.Add(new Product { ProductId = 6, CategoryId = 2, Name = "Macbook Pro", Image = "macbook_pro.jpg", Price = 129999, IsActive = true });
            _products.Add(new Product { ProductId = 7, CategoryId = 2, Name = "iMac", Image = "imac.jpg", Price = 199999, IsActive = true });
        }
    }
}
