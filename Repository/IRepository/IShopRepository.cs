using System.Collections.Generic;
using System.Threading.Tasks;
using zadanie.Models;
using zadanie.Repository.IRepository.RepositoryBase.IRepositoryBase;

namespace zadanie.Repository.IRepository
{
    public interface IShopRepository : IRepositoryBase<Shop>
    {
        Task<IEnumerable<Shop>> GetAllShopsAsync();
        Task<Shop> GetShopByIdAsync(int id);
        Task<Shop> GetShopWithDetailsByIdAsync(int id);
        void CreateShop(Shop shop);
        void UpdateShop(Shop shop);
        void DeleteShop(Shop shop);
    }
}
