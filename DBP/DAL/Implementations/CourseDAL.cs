using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class CourseDAL : ICourseDAL
    {
        private readonly IDbHelper dbHelper;

        public CourseDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Course?> Get(int id)
        {
            string sql = @"select * from Course where id = @id";

            return await dbHelper.QueryScalarAsync<Course>(sql, new { id = id });
        }
    }
}
