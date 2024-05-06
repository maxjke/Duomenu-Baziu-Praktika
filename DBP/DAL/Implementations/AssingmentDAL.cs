using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class AssingmentDAL : IAssingmentDAL
    {
        private readonly IDbHelper dbHelper;

        public AssingmentDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Assignment?> Get(int id)
        {
            string sql = @"select * from Assignment where id = @id";

            return await dbHelper.QueryScalarAsync<Assignment>(sql, new { id = id });
        }
    }
}
