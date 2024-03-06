using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infraestructure.Data.Repositories
{
    public class ProductRepository : RepositoryEF<Product>, IProductRepository
    {
        protected readonly string _connectionString;
        public ProductRepository(DbContext context,string connectionString) : base(context)
        {
            repositoryEF=new RepositoryEF<Product>(context);
            _connectionString=connectionString;
        }

        public async Task<List<Product>> GetListAll()
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            var resultado = await connection.QueryAsync<Product>("sp_list_products", commandType: CommandType.StoredProcedure);
            var listDetalleCompra = resultado.Cast<Product>().ToList();
            await connection.CloseAsync();
            return listDetalleCompra;
        }

        public async Task<Product> GetById(int Id)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            var parameters = new DynamicParameters();
            parameters.Add("Id", Id);
            var resultado = await connection.QueryFirstOrDefaultAsync<Product>("sp_product_by_id", parameters, commandType: CommandType.StoredProcedure);
            await connection.CloseAsync();
            return resultado;
        }
        public IRepositoryEF<Product> repositoryEF { get; set; }
        public async Task<Product> Insert(Product product)
        {
            return await repositoryEF.Insert(product);
        }
        public async Task  Update(Product product)
        {
          await   repositoryEF.Update(product);
        }
        public async Task Delete(int id)
        {
            await repositoryEF.Delete(d => d.Id == id);
        }
    }
}
