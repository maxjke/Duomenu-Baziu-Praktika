using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class StudentDAL : IStudentDAL
    {
        private readonly IDbHelper dbHelper;

        public StudentDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Student?> Get(int id)
        {
            string sql = "select * from Student where id = @id";

            return await dbHelper.QueryScalarAsync<Student>(sql, new { id = id });
        }
    }
}
