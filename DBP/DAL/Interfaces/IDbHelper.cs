using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDbHelper
    {
        Task<T?> QueryScalarAsync<T>(string sql, object model);
        Task ExecuteAsync(string sql, object model);
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object model);
    }
}
