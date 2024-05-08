using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IContactInfoDAL
    {
        Task<ContactInfo?> Get(int id);
        Task<List<ContactInfo>> GetAll(List<int?> id);
        Task<int> Create(ContactInfo contactInfo);
    }
}
