using API.Dtos;
using API.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var datas= await _categoryRepository.GetAllAsync();

            return Ok(datas);
        }
        [HttpPost]
        public async Task<ActionResult> CreateCategory(CreateCategoryDTO createCategoryDTO)
        {

            _categoryRepository.AddCategoryAsync(createCategoryDTO);
            return Ok("Kategori Başarıyla Eklendi");
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategoryAsync(id);
            return Ok("Kategori silindi");
        }
    }
}
