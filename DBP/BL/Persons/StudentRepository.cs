using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace BL.Persons
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IContactInfoDAL contactInfo;
        private readonly IStudentDAL studentDal;

        public StudentRepository(IContactInfoDAL contactInfo, IStudentDAL studentDal)
        {
            this.contactInfo = contactInfo;
            this.studentDal = studentDal;
        }


        public async Task Create(Student student)
        {
            var contId = await contactInfo.Create(student.ContactInfo);

            student.contactinfo_id = contId;

            await studentDal.Create(student);
        }
    }
}
