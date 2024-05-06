using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class PaymentMethodDAL : IPaymentMethodDAL
    {
        private readonly IDbHelper dbHelper;

        public PaymentMethodDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<PaymentMethod?> Get(int id)
        {
            string sql = "select * from PaymentMethod where id = @id";

            return await dbHelper.QueryScalarAsync<PaymentMethod>(sql, new { id = id });
        }
    }
}
