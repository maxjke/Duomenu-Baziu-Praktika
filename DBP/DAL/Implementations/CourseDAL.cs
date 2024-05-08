using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class CourseDAL : ICourseDAL
    {
        private readonly IDbHelper dbHelper;

        public CourseDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task Create(Course course,string TeacherName)
        {
            string sql = @"insert into Course(CourseName,Duration,Price, teacher_id) 
                           values(@name, @duration, @price,
                           (select Teacher.id from Teacher
                           join ContactInfo ON ContactInfo.id = Teacher.contactinfo_id
                           where ContactInfo.name = @TeacherName));";
             await dbHelper.ExecuteAsync(sql, new {name=course.CourseName, duration=course.Duration,price=course.Price,TeacherName= TeacherName});
        }

        public async Task<Course?> Get(int id)
        {
            string sql = @"select * from Course where id = @id";

            return await dbHelper.QueryScalarAsync<Course>(sql, new { id = id });
        }
    }
}
