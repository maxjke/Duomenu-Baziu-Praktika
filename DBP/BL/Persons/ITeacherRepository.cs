using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Persons
{
    public interface ITeacherRepository
    {
        Task Create(Teacher teacher);

        Task Update(ContactInfo teacher);

        Task Delete(Teacher teacher);
        Task<Teacher?> Get(int id);
    }
}
