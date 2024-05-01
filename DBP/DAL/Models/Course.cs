using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Course : Entity
    {
        public string CourseName { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Duration {  get; set; }

        [ForeignKey("Teacher")]
        public Teacher teacher { get; set; }
       
        public int Teacher_id { get; set; }

        [ForeignKey("Lecture")]
        public List<Lecture> lectures { get; set; }

        public List<int> Lectures_id { get; set; }
    }
}
