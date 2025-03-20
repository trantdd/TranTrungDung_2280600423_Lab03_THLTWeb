using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TranTrungDung_2280600423_Lab03WebBanHang.Models;
using TranTrungDung_2280600423_Lab03WebBanHang.Repositories;

namespace TranTrungDung_2280600423_Lab03WebBanHang.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync();
            return View(products);
        }
    }
}
