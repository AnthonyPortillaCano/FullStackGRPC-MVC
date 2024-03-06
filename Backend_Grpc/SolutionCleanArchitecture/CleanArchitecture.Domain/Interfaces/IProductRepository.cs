using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetListAll();
        Task<Product> GetById(int Id);
        Task<Product> Insert(Product product);

        Task Update(Product product);
        Task Delete(int id);
    }
}
