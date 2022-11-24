using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return await GetByCondition(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Shop> GetShopWithDetailsByIdAsync(int id)
        {
            return await GetByCondition(p => p.Id == id).Include(p => p.Products).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Shop>> GetAllShopsAsync()
        {
            return await GetAll()
                .OrderBy(p => p.Id)
                .ToListAsync();
        }
        public void CreateShop(Shop shop)
        {
            Create(shop);
        }

        public void DeleteShop(Shop shop)
        {
            Delete(shop);
        }

        public void UpdateShop(Shop shop)
        {
            Update(shop);
        }
    }
}
