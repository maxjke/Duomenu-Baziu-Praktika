using System;
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
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        
        public virtual Teacher Teacher { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        
        public virtual Student Student { get; set; }
    }
}
