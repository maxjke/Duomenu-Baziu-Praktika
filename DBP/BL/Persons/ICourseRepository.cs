﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Persons
{
    public interface ICourseRepository
    {
        Task Create(Course course,string teacherName);
    }
}
