﻿using TranTrungDung_2280600423_Lab03WebBanHang.Models;

namespace TranTrungDung_2280600423_Lab03WebBanHang.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(int id);

    }
}
