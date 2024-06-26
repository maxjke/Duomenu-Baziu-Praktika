﻿using DAL.Implementations;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Persons
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly IContactInfoDAL contactInfo;
        private readonly ITeacherDAL teacherDAL;

        public TeacherRepository(IContactInfoDAL contactInfo, ITeacherDAL teacherDAL)
        {
            this.contactInfo = contactInfo;
            this.teacherDAL = teacherDAL;
        }


        public async Task Create(Teacher teacher)
        {
            var contId = await contactInfo.Create(teacher.ContactInfo);

            teacher.contactinfo_id = contId;

            await teacherDAL.Create(teacher);
        }

        public async Task Delete(int id)
        {
            var teacher = await Get(id);

            await teacherDAL.DeleteContact((int)teacher.contactinfo_id);

            await teacherDAL.DeleteTeacher(id);


        }

        public async Task Update(ContactInfo teacher)
        {
            await contactInfo.Update(teacher);
        }

        public async Task<Teacher?> Get(int id)
        {
            return await teacherDAL.Get(id);
        }

        
    }
}

