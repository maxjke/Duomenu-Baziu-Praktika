using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class CareerCenterDAL : ICareerCenterDAL
    {
        readonly IDbHelper dbHelper;

        public CareerCenterDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<CareerCenter?> Get(int id)
        {
            string sql = @"select * from Assignment where id = @id";

            return await dbHelper.QueryScalarAsync<CareerCenter>(sql, new { id = id });
        }
    }
}
