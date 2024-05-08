using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Interfaces
{
    public interface ICompanyDAL
    {
        Task<Company?> Get(int idCompany);

        Task Create(Company company);
    }
}
