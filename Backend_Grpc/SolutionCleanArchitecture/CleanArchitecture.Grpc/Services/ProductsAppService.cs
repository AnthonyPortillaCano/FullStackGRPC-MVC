using CleanArchitecture.Application.Interfaces;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;

namespace CleanArchitecture.Grpc.Services
{
    public class ProductsAppService : ProductsService.ProductsServiceBase
    {
        private readonly IUnitOfWork  _unitOfWork;
        public ProductsAppService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public override async Task<Products> GetAll(Empty request, ServerCallContext context)
        {
            Products response = new();
            var resultProduct = await _unitOfWork.productServices.GetAll();
            var products = JsonConvert.DeserializeObject<Product[]?>(JsonConvert.SerializeObject(resultProduct));
            response.Items.AddRange(products);
            return response;
        }
        public override async Task<Product> GetById(ProductRowIdFilter request, ServerCallContext context)
        {
            var product = await _unitOfWork.productServices.GetById(request.Id);
            var sProduct = JsonConvert.DeserializeObject<Product?>(JsonConvert.SerializeObject(product));
            return sProduct!;
	    }
        public override async Task<Product> Post(Product request, ServerCallContext context)
        {
                    var product = new Domain.Models.Product()
                    {
                        ProductName = request.ProductName,
                       Price = request.Price, 
                       Id = request.Id,
                      ProductType = request.ProductType
                    };
                    var productResult=await _unitOfWork.productServices.Insert(product);
                   var result = new Product()
                   {
                ProductName = productResult.ProductName,
                Price = (int)productResult.Price,
                Id = productResult.Id,
                ProductType = productResult.ProductType
                 };
            return await Task.FromResult<Product>(result);
        }
        public override  async Task<Empty> Put(Product request, ServerCallContext context)
        {
                    var product = new Domain.Models.Product()
                    {
                        ProductName = request.ProductName,
                       Price = request.Price, 
                       Id = request.Id,
                      ProductType = request.ProductType
                    };
                    await _unitOfWork.productServices.Update(product);
                    return await Task.FromResult<Empty>(new Empty());
        }
        public override async Task<Empty> Delete(ProductRowIdFilter request, ServerCallContext context)
        {
            await _unitOfWork.productServices.Delete(request.Id);
            return await Task.FromResult<Empty>(new Empty());
        }
    }
}
