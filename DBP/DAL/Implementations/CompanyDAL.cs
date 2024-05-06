using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Implementations
{
    public class CompanyDAL : ICompanyDAL
    {
        private readonly IDbHelper dbHelper;

        public CompanyDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Company?> Get(int idCompany)
        {
            string sql = "select id, CompanyName, CompanyDescription from Company where idCompany = @idCompany";

            return await dbHelper.QueryScalarAsync<Company>(sql,new {idCompany = idCompany});
        }
    }
}
