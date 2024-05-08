using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Persons
{
    public class CompanyRepository : ICompanyRepository
    {
      
        private readonly ICompanyDAL companyDAL;

        public CompanyRepository(ICompanyDAL companyDAL)
        {
           
            this.companyDAL = companyDAL;
        }


        public async Task Create(Company company)
        {

            await companyDAL.Create(company);
        }

        public async Task Delete(Company company)
        {
           await companyDAL.Delete(company);
        }
    }
}
