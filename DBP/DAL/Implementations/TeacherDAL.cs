using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Implementations
{
    public class TeacherDAL : ITeacherDAL
    {
        private readonly IDbHelper dbHelper;

        public TeacherDAL(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public async Task Create(Teacher teacher)
        {
            string sql = "insert into Teacher(contactinfo_id) value(@contactinfo_id)";

            await dbHelper.ExecuteAsync(sql, new { contactinfo_id = teacher.contactinfo_id });
        }

        public async Task DeleteTeacher(int id)
        {
            string sql = @"SET FOREIGN_KEY_CHECKS = 0;
                            DELETE FROM Teacher WHERE id = @Id;";

            await dbHelper.ExecuteAsync(sql, new { Id = id });
        }

        public async Task DeleteContact(int id)
        {
            string sql = @"SET FOREIGN_KEY_CHECKS = 0; 
                            DELETE FROM ContactInfo WHERE id = @Id";

            await dbHelper.ExecuteAsync(sql, new { Id = id });
        }

        public async Task<Teacher?> Get(int id)
        {
            string sql = "select * from Teacher where id = @id";

            return await dbHelper.QueryScalarAsync<Teacher>(sql, new { id = id });
        }

        public async Task Update(Teacher teacher)
        {
            string sql = "UPDATE Teacher" +
                         "SET contactinfo_id = @contactinfo_id" +
                         "WHERE id = @Id";

            await dbHelper.ExecuteAsync(sql, new { contactinfo_id = teacher.contactinfo_id, Id = teacher.Id });
        }
    }
}
