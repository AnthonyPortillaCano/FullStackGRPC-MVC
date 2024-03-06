using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infraestructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Services
{
    public class ProductService: IProductService
    {
        protected IProductRepository _productRepository;
        public ProductService(DbContext context, string connectionString)
        {
            _productRepository = new ProductRepository(context, connectionString);
        }
        public async Task<List<Product>> GetAll()
        {
            return await _productRepository.GetListAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await _productRepository.GetById(id);
        }
        public async Task<Product> Insert(Product product)
        {
            return await _productRepository.Insert(product);
        }
        public async Task  Update(Product product)
        {
            await _productRepository.Update(product);
        }

        public async Task Delete(int id)
        {
            await _productRepository.Delete(id);
        }
    }
}
