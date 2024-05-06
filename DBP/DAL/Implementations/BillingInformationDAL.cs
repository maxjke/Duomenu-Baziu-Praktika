using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class BillingInformationDAL : IBillingInformationDAL
    {
        private readonly IDbHelper dbHelper;
        public BillingInformationDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }
        public async Task<BillingInformation?> Get(int idbillinginformation)
        {
            string sql = @"select * from BillingInformation where id = @idbillinginformation";

            return await dbHelper.QueryScalarAsync<BillingInformation>(sql, new { idbillinginformation = idbillinginformation });
        }
      

        

       
    
}
}
