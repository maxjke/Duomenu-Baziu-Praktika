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

        public async Task Update(Student student)
        {
            string sql = "UPDATE Student" +
                         "SET group_id = @groupId" +
                         "SET contactinfo_id = @contactinfo_id" +
                         "WHERE id = @Id";

            await dbHelper.ExecuteAsync(sql, new { contactinfo_id = student.contactinfo_id, group_id = student.group_id, Id = student.Id });
        }

        public async Task DeleteStudent(int id)
        {
            string sql = @"SET FOREIGN_KEY_CHECKS = 0;
                            DELETE FROM Student WHERE id = @Id;";

            await dbHelper.ExecuteAsync(sql, new { Id = id });
        }

        public async Task DeleteContact(int id)
        {
            string sql = @"SET FOREIGN_KEY_CHECKS = 0; 
                            DELETE FROM ContactInfo WHERE id = @Id";

            await dbHelper.ExecuteAsync(sql, new { Id = id });
        }
    }
}
