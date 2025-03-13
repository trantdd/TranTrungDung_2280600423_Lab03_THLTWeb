using TranTrungDung_2280600423_Lab03WebBanHang.Models;

namespace TranTrungDung_2280600423_Lab03WebBanHang.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);

    }
}
