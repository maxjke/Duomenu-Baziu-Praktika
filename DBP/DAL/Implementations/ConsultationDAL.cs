using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ConsultationDAL : IConsultationDAL
    {
        readonly IDbHelper dbHelper;

        public ConsultationDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Consultation?> Get(int id)
        {
            string sql = @"select * from Consultation where id = @id";

            return await dbHelper.QueryScalarAsync<Consultation>(sql, new { id = id });
        }
    }
}
