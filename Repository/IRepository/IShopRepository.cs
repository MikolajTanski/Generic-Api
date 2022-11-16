using System.Collections.Generic;
using zadanie.Models;

namespace zadanie.Repository.IRepository
{
    public interface IShopRepository
    {
        public IEnumerable<Shop> GetShops();
        public void InsertShop(Shop shop);
        public Shop GetShopById(int shopId);
        public void DeleteShop(Shop shop);
        public void UpdateShop(Shop shop);
        public void Save();
    }
}
