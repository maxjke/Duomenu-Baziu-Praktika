using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class StudentDAL : IStudentDAL
    {
        private readonly IDbHelper dbHelper;

        public StudentDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task<Student?> Get(int id)
        {
            string sql = "select * from Student where id = @id";

            return await dbHelper.QueryScalarAsync<Student>(sql, new { id = id });
        }

        public async Task Create(Student student)
        {
            string sql = "insert into Student(group_id,contactinfo_id) values(1,@contactinfo_id)";

            await dbHelper.ExecuteAsync(sql, new { contactinfo_id = student.contactinfo_id });
        }

        public async Task<List<Student>> GetAll()
        {
            string sql = "select * from Student";

            return (await dbHelper.QueryAsync<Student>(sql, new { })).ToList();
        }
    }
}
