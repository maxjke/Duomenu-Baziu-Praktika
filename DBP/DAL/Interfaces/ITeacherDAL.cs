﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ITeacherDAL
    {
        Task<Teacher?> Get(int id);

        Task Create(Teacher teacher);
        Task Update(Teacher teacher);

        Task DeleteTeacher(int id);
        Task DeleteContact(int id);
    }
}
