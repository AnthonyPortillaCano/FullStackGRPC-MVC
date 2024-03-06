using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Infraestructure.Data.Context;

namespace CleanArchitecture.Application.Services
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly BdcompanyContext _context;
        public UnitOfWork(BdcompanyContext context, string connectionString)
        {
            _context = context;
            productServices = new ProductService(context, connectionString);
        }
        public IProductService productServices { get; private set; }
       
    }
}
