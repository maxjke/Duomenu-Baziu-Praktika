﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Grade : Entity
    {
     
        public int GradeValue {  get; set; }

        public int StudentId {  get; set; }

        public Student? Student {  get; set; }

    }
}
