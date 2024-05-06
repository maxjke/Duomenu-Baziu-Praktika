using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class LectureDAL : ILectureDAL
    {
        readonly IDbHelper dbHelper;

        public LectureDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Lecture?> Get(int id)
        {
            string sql = @"select * from Lecture where id = @id";

            return await dbHelper.QueryScalarAsync<Lecture>(sql, new { id = id });
        }
    }
}
