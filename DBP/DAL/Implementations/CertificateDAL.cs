using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class CertificateDAL : ICertificateDAL
    {
        private readonly IDbHelper dbHelper;

        public CertificateDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Certificate?> Get(int id)
        {
            string sql = @"select * from Certificate where id = @id";

            return await dbHelper.QueryScalarAsync<Certificate>(sql, new { id = id });
        }
    }
}
