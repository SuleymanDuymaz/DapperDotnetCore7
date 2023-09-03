using API.Dtos;
using API.Dtos.ProductDTOs;
using API.Models.DapperContext;
using API.Repositories.Abstract;
using Dapper;

namespace API.Repositories.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductWithCategoryDTO>> GetAllProductWithCategoryAsync()
        {
            string query = @"
        SELECT
            P.ID,
            P.TITLE,
            P.PRICE,
            P.CITY,
            P.DISTRICT,
            C.NAME AS CATEGORYNAME,
            P.COVERIMAGE,
            'TYPE_VALUE' AS TYPE,
            P.ADDRESS
        FROM
            PRODUCTS AS P
        INNER JOIN
            CATEGORIES AS C
        ON
            P.PRODUCTCATEGORY = C.ID
    ";

            using (var connection = _context.CreateConnection())
            {
                var datas = await connection.QueryAsync<ResultProductWithCategoryDTO>(query);
                return datas.ToList();
            }
        }


        public async Task<List<ResultProductDTO>> GetProductsAsync()
        {
            string query = "SELECT *FROM PRODUCTS";
            using (var connection = _context.CreateConnection())
            {
                var datas = await connection.QueryAsync<ResultProductDTO>(query);
                return datas.ToList();
            }


        }

    }
}
