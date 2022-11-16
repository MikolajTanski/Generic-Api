using System.Collections.Generic;
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

        public void DeleteShop(int shopId)
        {
            var shop = _shopRepository.GetShopById(shopId);
            _shopRepository.DeleteShop(shop);
        }

        public Shop GetShopById(int shopId)
        {
            var result = _shopRepository.GetShopById(shopId);
            return result;
        }
        public IEnumerable<Shop> GetShops()
        {
            var result = _shopRepository.GetShops();
            return result;
        }

        public void InsertShop(Shop shop)
        {
            _shopRepository.InsertShop(shop);
        }

        public void Save()
        {
            _shopRepository.Save();
        }

        public void UpdateShop(Shop shop)
        {
            _shopRepository.UpdateShop(shop);
        }

    }
}
