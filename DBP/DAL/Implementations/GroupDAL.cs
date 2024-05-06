using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class GroupDAL : IGroupDAL
    {
        private readonly IDbHelper dbHelper;

        public GroupDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Group?> Get(int id)
        {
            string sql = "select * from Group where id = @id";

            return await dbHelper.QueryScalarAsync<Group>(sql, new { id = id });
        }
    }
}
