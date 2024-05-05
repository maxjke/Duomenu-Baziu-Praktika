using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class AdvertisementDAL : IAdvertisementDAL
    {
        private readonly IDbHelper dbHelper;

        public AdvertisementDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Advertisement?> Get(int idAdvertisement)
        {
            string sql = @"select * from Advertisement where idAdverisement = @idAdvertisement";

            return await dbHelper.QueryScalarAsync<Advertisement>(sql, new { idAdvertisement = idAdvertisement });
        }
    }
}
