using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class CompanyOfferDAL : ICompanyOfferDAL
    {
        private readonly IDbHelper dbHelper;
        public CompanyOfferDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }
        public async Task<CompanyOffer?> Get(int id)
        {
            string sql = @"select * from CompanyOffer where id = @id";

            return await dbHelper.QueryScalarAsync<CompanyOffer>(sql, new { idbillinginformation = id });
        }
    }
}
