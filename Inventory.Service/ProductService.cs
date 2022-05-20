using Inventory.Domain.Abstractions;

namespace Inventory.Service
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        // Implements methods to the Product Service 
    }
}
