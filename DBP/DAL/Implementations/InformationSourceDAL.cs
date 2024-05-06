using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class InformationSourceDAL : IInformationSourceDAL
    {
        private readonly IDbHelper dbHelper;

        public InformationSourceDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<InformationSource?> Get(int id)
        {
            string sql = @"select * from InformationSource where id = @id";

            return await dbHelper.QueryScalarAsync<InformationSource>(sql, new { id = id });
        }
    }
}
