using ProjetoExemplo.Models;
using ProjetoExemplo.Repositories.Interface;
using ProjetoExemplo.Services.Interface;

namespace ProjetoExemplo.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts() { return _productRepository.GetAll(); }
    }
}
