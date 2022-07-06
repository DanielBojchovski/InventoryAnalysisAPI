using InventoryAnalysisApi2.Models;

namespace InventoryAnalysisApi2.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> SearchByName(string name);
        Task<IEnumerable<Product>> Get();
        Task<Product> Get(int productId);
        Task<Product> Create(Product product);
        Task<Product> Update(Product product);
        Task Delete(int productId);
    }
}
