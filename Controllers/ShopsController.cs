using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using zadanie.Models;
using zadanie.Servis;
using zadanie.Servis.IService;

namespace zadanie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopsController : ControllerBase
    {
        private readonly IShopService _shopService;

        public ShopsController(ShopService shopService)
        {
            _shopService = shopService;
        }

        [HttpGet("Get")]
        public async Task<IEnumerable<Shop>> GetShops()
        {
            var result = await _shopService.GetAllAsync();
            return result;
        }

        [HttpGet("GetWithDetails/{id}")]
        public async Task<Shop> GetShopWithDetail(int id)
        {
            var result = await _shopService.GetWithDetailsByIdAsync(id);
            return result;
        }

        [HttpGet("Get/{id}")]
        public async Task<Shop> GetShopById(int id)
        {
            var result = await _shopService.GetByIdAsync(id);
            return result;
        }

        [HttpPut("Put")]
        public void AddShop([FromBody] Shop shop)
        {
            _shopService.Update(shop);
        }

        [HttpPost("Post")]
        public void PostShop([FromBody] Shop shop)
        {
            _shopService.Create(shop);
        }

        [HttpDelete("Delete/{id}")]
        public void DeleteShop(int id)
        {
            _shopService.Delete(id);
        }
    }
}
