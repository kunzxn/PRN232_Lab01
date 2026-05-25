using System.Collections.Generic;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public List<Product> GetProducts() => _productRepository.GetProducts();
        public Product GetProductById(int id) => _productRepository.GetProductById(id);
        public void SaveProduct(Product p) => _productRepository.SaveProduct(p);
        public void UpdateProduct(Product p) => _productRepository.UpdateProduct(p);
        public void DeleteProduct(Product p) => _productRepository.DeleteProduct(p);
    }
}
