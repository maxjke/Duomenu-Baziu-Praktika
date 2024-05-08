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

        public async Task<Teacher?> Get(int id)
        {
            string sql = "select * from Teacher where id = @id";

            return await dbHelper.QueryScalarAsync<Teacher>(sql, new { id = id });
        }

        public async Task Update(Teacher teacher,int id)
        {
            string sql = "update Teacher set contactinfo_id = @ContactInfoId where id = @id";

            await dbHelper.ExecuteAsync(sql, new {ContactInfoId= teacher.contactinfo_id, id=id });
        }
    }
}
