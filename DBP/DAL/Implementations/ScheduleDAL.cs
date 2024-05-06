using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ScheduleDAL : IScheduleDAL
    {
        private readonly IDbHelper dbHelper;

        public ScheduleDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Schedule?> Get(int id)
        {
            string sql = "select * from Schedule where id = @id";

            return await dbHelper.QueryScalarAsync<Schedule>(sql, new { id = id });
        }
    }
}
