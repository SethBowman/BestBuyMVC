using BestBuyMVC.Models;

namespace BestBuyMVC
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProductById(int id);
        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        public void DeleteProduct(Product product);
    }
}
