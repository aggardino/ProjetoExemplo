using ProjetoExemplo.Models;

namespace ProjetoExemplo.Services.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
    }
}
