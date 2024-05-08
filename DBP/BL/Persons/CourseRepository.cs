using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Persons
{
    public class CourseRepository : ICourseRepository
    {
       
        private readonly ICourseDAL courseDAL;

        public CourseRepository(ICourseDAL courseDAL)
        {
           
            this.courseDAL = courseDAL;
        }


        public async Task Create(Course course,string teacherName)
        {

            await courseDAL.Create(course,teacherName);
        }
    }
}
