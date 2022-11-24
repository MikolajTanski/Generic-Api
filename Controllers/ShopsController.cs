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

        // GET: api/Shops
        [HttpGet]
        public async Task<IEnumerable<Shop>> GetShop()
        {
            var result = await _shopService.GetAllAsync();
            return result;
        }

        // GET: api/Shops/5
        [HttpGet("Get/{id}")]
        public async Task<Shop> GetShopById(int id)
        {
            var result = await _shopService.GetByIdAsync(id);
            return result;
        }

        // PUT: api/Shops/5
        [HttpPut("Add")]
        public void AddShop([FromBody] Shop shop)
        {
            _shopService.Update(shop);
        }

        // POST: api/Shops
        [HttpPost("Post")]
        public void PostShop([FromBody] Shop shop)
        {
            _shopService.Create(shop);
        }
        // DELETE: api/Shops/5
        [HttpDelete("Delete/{id}")]
        public void DeleteShop(int id)
        {
            _shopService.Delete(id);
        }
    }
}
