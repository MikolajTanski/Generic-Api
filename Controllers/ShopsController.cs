using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using zadanie.Models;
using zadanie.Servis;

namespace zadanie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopsController : ControllerBase
    {
        private readonly ShopService _shopService;

        public ShopsController(ShopService shopService)
        {
            _shopService = shopService;
        }

        // GET: api/Shops
        [HttpGet]
        public IEnumerable<Shop> GetShops()
        {
            var result = _shopService.GetShops();
            return result;
        }

        // GET: api/Shops/5
        [HttpGet("Get/{id}")]
        public Shop GetShop(int id)
        {
            var shop = _shopService.GetShopById(id);

            return shop;
        }

        // PUT: api/Shops/5
        [HttpPut("Put")]
        public void PutShop([FromBody] Shop shop)
        {
            _shopService.UpdateShop(shop);
            _shopService.Save();
        }

        // POST: api/Shops
        [HttpPost("Post")]
        public void PostShop([FromBody] Shop shop)
        {
            _shopService.InsertShop(shop);
            _shopService.Save();
        }
        // DELETE: api/Shops/5
        [HttpDelete("Delete/{id}")]
        public void DeleteShop(int id)
        {
            _shopService.DeleteShop(id);
            _shopService.Save();
        }
    }
}
