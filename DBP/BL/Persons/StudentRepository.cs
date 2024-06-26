﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;

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

        public async Task<List<ContactInfo>> FindAll()
        {
            var x = ((await studentDal.GetAll()).Select(x =>x.contactinfo_id) ).ToList();
            return await contactInfo.GetAll(x);
        }

        public async Task Update(ContactInfo student)
        {
           await contactInfo.Update(student);
        }

        public async Task<Student?> Get(int id)
        {
            return await studentDal.Get(id);
        }

        public async Task Delete(int id)
        {
            var student = await Get(id);

                await studentDal.DeleteContact((int)student.contactinfo_id);

                await studentDal.DeleteStudent(id);


        }
    }
}
