using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class OrderDAL : IOrderDAL
    {
        private readonly IDbHelper dbHelper;

        public OrderDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Order?> Get(int id)
        {
            string sql = @"select * from Order where id = @id";

            return await dbHelper.QueryScalarAsync<Order>(sql, new { id = id });
        }
    }
}

