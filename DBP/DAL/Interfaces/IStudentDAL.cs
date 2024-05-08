using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IStudentDAL
    {
        Task<Student?> Get(int id);
        Task<List<Student>> GetAll();
        Task Create(Student student);
        Task Update(Student student);
        Task DeleteStudent(int id);
        Task DeleteContact(int id);
    }
}
