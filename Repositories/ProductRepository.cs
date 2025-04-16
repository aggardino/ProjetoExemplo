using ProjetoExemplo.Models;
using ProjetoExemplo.Repositories.Interface;

namespace ProjetoExemplo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private static readonly List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Produto A", Price = 10.0m },
            new Product { Id = 2, Name = "Produto B", Price = 12.0m }
        };

        public IEnumerable<Product> GetAll()
        {
            return products;
        }
    }
}
