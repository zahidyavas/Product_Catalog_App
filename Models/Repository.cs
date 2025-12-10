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
    }
}
