using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using zadanie.Models;
using zadanie.Repository.IRepository;

namespace zadanie.Repository
{
    public class ShopRepository : IShopRepository
    {
        private readonly DataContext _db;
        public ShopRepository(DataContext db)
        {
            _db = db;
        }

        public void DeleteShop(Shop shop)
        {
            _db.Shops.Remove(shop);
        }

        public Shop GetShopById(int shopId)
        {
            return _db.Shops.Include(s => s.Products).Where(s => s.Id == shopId).FirstOrDefault();
        }

        public IEnumerable<Shop> GetShops()
        {
            return _db.Shops.Include(s => s.Products).ToList();
        }

        public void InsertShop(Shop shop)
        {
            _db.Shops.Add(shop);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void UpdateShop(Shop shop)
        {
            _db.Entry(shop).State = EntityState.Modified;
        }
    }
}
