using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zadanie.Data;
using zadanie.Exception;
using zadanie.Models;
using zadanie.Repository.IRepository;
using zadanie.Repository.IRepository.RepositoryBase;

namespace zadanie.Repository
{
    public class ShopRepository : RepositoryBase<Shop>, IShopRepository
    {
        public ShopRepository(DataContext db) : base(db)
        {
        }

        public async Task<Shop> GetShopByIdAsync(int id)
        {

            var shop = await GetByCondition(s => s.Id == id).FirstOrDefaultAsync();

            if (shop == null) throw new NotFoundException("shop is not found");

            return shop;
        }

        public async Task<Shop> GetShopWithDetailsByIdAsync(int id)
        {

            var shop = await GetByCondition(s => s.Id == id).Include(p => p.Products).FirstOrDefaultAsync();

            if (shop == null) throw new NotFoundException("shop is not found");

            return shop;
        }
        public async Task<IEnumerable<Shop>> GetAllShopsAsync()
        {

            var shop = await GetAll()
                .OrderBy(s => s.Id)
                .Include(p => p.Products)
                .ToListAsync();

            if (shop == null) throw new NotFoundException("shop is not found");

            return shop;
        }
        public void CreateShop(Shop shop)
        {
            Create(shop);
        }

        public void DeleteShop(Shop shop)
        {
            if (shop == null) throw new NotFoundException("shop is not found");
            Delete(shop);
        }

        public void UpdateShop(Shop shop)
        {
            if (shop == null) throw new NotFoundException("shop is not found");
            Update(shop);
        }
    }
}
