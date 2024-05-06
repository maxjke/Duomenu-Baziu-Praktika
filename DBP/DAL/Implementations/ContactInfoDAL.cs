using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ContactInfoDAL : IContactInfoDAL
    {
        readonly IDbHelper dbHelper;

        public ContactInfoDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<ContactInfo?> Get(int id)
        {
            string sql = @"select * from ContactInfo where id = @id";

            return await dbHelper.QueryScalarAsync<ContactInfo>(sql, new { id = id });
        }
    }
}
