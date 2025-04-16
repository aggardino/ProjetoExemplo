using ProjetoExemplo.Models;

namespace ProjetoExemplo.Repositories.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
