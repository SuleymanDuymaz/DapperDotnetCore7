using API.Dtos;
using API.Models.DapperContext;
using API.Repositories.Abstract;
using Dapper;

namespace API.Repositories.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void AddCategoryAsync(CreateCategoryDTO categoryDTO)
        {
            string query = "insert into CATEGORIES (NAME,STATUS) values (@NAME,@STATUS)";
            var parameters = new DynamicParameters();
            parameters.Add("@NAME", categoryDTO.NAME);
            parameters.Add("@STATUS", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void  DeleteCategoryAsync(int id)
        {
            string query = "Delete From CATEGORIES Where ID=@ID";
            var parameters = new DynamicParameters();
            parameters.Add("@ID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDTO>> GetAllAsync()
        {
            string query = "select *From CATEGORIES";
            using(var connection =_context.CreateConnection())
            {
                var datas=await connection.QueryAsync<ResultCategoryDTO>(query);
                return datas.ToList();


            }

        }
    }
}
