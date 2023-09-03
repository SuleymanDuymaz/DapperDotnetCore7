using API.Dtos;

namespace API.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        public Task<List<ResultCategoryDTO>> GetAllAsync();
        void AddCategoryAsync(CreateCategoryDTO categoryDTO);
        void  DeleteCategoryAsync(int id);
        void UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO);
    }
}
