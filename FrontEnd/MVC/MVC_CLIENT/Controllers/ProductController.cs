using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using static MVC_CLIENT.ProductsService;
namespace MVC_CLIENT.Controllers
{
    public class ProductController : Controller
    {
        private readonly string GrpcChannelURL = "https://localhost:7191";
        // GET: ProductController
        public ActionResult Index()
        {
            using var channel = GrpcChannel.ForAddress(GrpcChannelURL);
            var client = new ProductsServiceClient(channel);
            var products = client.GetAll(new Empty { });
            return View(products);
        }

        // GET: ProductController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var channel = GrpcChannel.ForAddress(GrpcChannelURL);
            var client = new ProductsServiceClient(channel);
            var product = await client.GetByIdAsync(new ProductRowIdFilter { Id = id });
            return View(product);
        }
        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Product product)
        {
            try
            {
                var channel = GrpcChannel.ForAddress(GrpcChannelURL);
                var client = new ProductsServiceClient(channel);
                await  client.PutAsync(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }
        
        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product product)
        {
            try
            {
                using var channel = GrpcChannel.ForAddress(GrpcChannelURL);
                var client = new ProductsServiceClient(channel);
                await client.PostAsync(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: ProductController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var channel = GrpcChannel.ForAddress(GrpcChannelURL);
            var client = new ProductsServiceClient(channel);
            var product = await client.GetByIdAsync(new ProductRowIdFilter { Id = id });
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var channel = GrpcChannel.ForAddress(GrpcChannelURL);
                var client = new ProductsServiceClient(channel);
                client.DeleteAsync(new ProductRowIdFilter { Id = id });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
