using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ReviewDAL : IReviewDAL
    {
        private readonly IDbHelper dbHelper;

        public ReviewDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Review?> Get(int id)
        {
            string sql = "select * from Review where id = @id";

            return await dbHelper.QueryScalarAsync<Review>(sql, new { idCompany = id });
        }
    }
}
