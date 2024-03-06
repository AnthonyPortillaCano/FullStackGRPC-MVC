using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> Insert(Product product);
        Task Update(Product product);
        Task Delete(int id);
    }
}
