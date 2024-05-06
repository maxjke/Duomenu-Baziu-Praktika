using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class GradeDAL : IGradeDAL
    {
        private readonly IDbHelper dbHelper;

        public GradeDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Grade?> Get(int id)   
        {
            string sql = "select * where id = @id";

            return await dbHelper.QueryScalarAsync<Grade>(sql, new { id = id });
        }
    }
}
