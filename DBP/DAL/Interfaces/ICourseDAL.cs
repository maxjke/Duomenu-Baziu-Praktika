using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICourseDAL
    {
        Task<Course?> Get(int id);

        Task Create(Course course,string TeacherName);
    }
}
