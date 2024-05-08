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
<<<<<<< HEAD

        Task<int> Update(ContactInfo contactInfo);
=======
        Task Update(ContactInfo info);
>>>>>>> bafcc16e1ea6a6dbbcbb1b34fd652f78238b1ec5
    }
}
