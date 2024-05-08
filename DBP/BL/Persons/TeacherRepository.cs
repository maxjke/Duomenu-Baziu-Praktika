﻿using DAL.Interfaces;
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

        public async Task Delete(Teacher teacher)
        {
            await teacherDAL.Delete(teacher.Id);
        }

        public async Task Update(Teacher teacher)
        {
            var contId=await contactInfo.Update(teacher.ContactInfo);

            teacher.contactinfo_id=contId;

            await teacherDAL.Update(teacher,teacher.Id);
        }
    }
}
