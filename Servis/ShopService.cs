using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using zadanie.Models;
using zadanie.Repository.IRepository;
using zadanie.Servis.IService;

namespace zadanie.Servis
{
    public class ShopService : IShopService
    {
        private readonly IShopRepository _shopRepository;

        public ShopService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public void Create(Shop entity)
        {
            _shopRepository.CreateShop(entity);
        }

        public async void Delete(int id)
        {
            var shop = await GetByIdAsync(id);
            _shopRepository.Delete(shop);
        }

        public async Task<List<Shop>> GetAllAsync()
        {
            var shops = await _shopRepository.GetAllShopsAsync();
            return shops.ToList();
        }

        public IEnumerable<Shop> GetByCondition(Expression<Func<Shop, bool>> expression)
        {
            var shop = _shopRepository.GetByCondition(expression).ToList();
            return shop;
        }

        public async Task<Shop> GetByIdAsync(int id)
        {
            var shop = await _shopRepository.GetShopByIdAsync(id);
            return shop;
        }

        public async Task<Shop> GetWithDetailsByIdAsync(int id)
        {
            var shop = await _shopRepository.GetShopWithDetailsByIdAsync(id);
            return shop;
        }

        public void Update(Shop entity)
        {
            _shopRepository.UpdateShop(entity);
        }
    }
}
