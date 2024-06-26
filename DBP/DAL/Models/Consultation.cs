﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Consultation : Entity
    {
        public string ConsultationDate { get; set; }
        public int Duration { get; set; }
        public int teacher_id { get; set; }
        public Teacher Teacher { get; set; }

        public int student_id { get; set; }
        public Student Student { get; set; }
    }
}
