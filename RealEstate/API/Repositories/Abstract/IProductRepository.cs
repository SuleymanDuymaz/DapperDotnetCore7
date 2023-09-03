using API.Dtos.ProductDTOs;

namespace API.Repositories.Abstract
{
    public interface IProductRepository
    {
        public Task<List<ResultProductDTO>> GetProductsAsync();
        public Task<List<ResultProductWithCategoryDTO>> GetAllProductWithCategoryAsync();
    }
}
