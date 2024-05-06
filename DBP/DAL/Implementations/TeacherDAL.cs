using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class TeacherDAL : ITeacherDAL
    {
        private readonly IDbHelper dbHelper;

        public TeacherDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Teacher?> Get(int id)
        {
            string sql = "select * from Teacher where id = @id";

            return await dbHelper.QueryScalarAsync<Teacher>(sql, new { id = id });
        }
    }
}
