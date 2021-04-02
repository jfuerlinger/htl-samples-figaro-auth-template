using System.Collections.Generic;
using System.Threading.Tasks;
using Figaro.Core.DTOs;
using Figaro.Core.Entities;

namespace Figaro.Core.Contracts
{
  public interface IProductRepository
    {
        Task<int> GetCountAsync();
        Task AddRangeAsync(IEnumerable<Product> products);
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<Product> GetAsync(int productId);
        Task AddAsync(Product product);
    }
}