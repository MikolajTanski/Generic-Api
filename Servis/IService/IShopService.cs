using System.Collections.Generic;
using zadanie.Models;

namespace zadanie.Servis.IService
{
    public interface IShopService
    {
        public IEnumerable<Shop> GetShops();
        public void InsertShop(Shop shop);
        public Shop GetShopById(int shopId);
        public void DeleteShop(int shopId);
        public void UpdateShop(Shop shop);
        public void Save();
    }
}
