using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Persons
{
    public interface IStudentRepository
    {
        Task Create(Student student);

        Task<List<ContactInfo>> FindAll();

        Task Update(ContactInfo student);

        Task<Student?> Get(int id);

        Task Delete(int id);
    }
}
