using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Course : Entity
    {
        public string CourseName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public Teacher Teacher { get; set; }
        public  Advertisement? Advertisement { get; set; }
        public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();
        public  Group Group { get; set; }
        public  Certificate? Certificate { get; set; }

        public ICollection<CourseSources> CourseSources { get; set;} = new List<CourseSources>();

        
    }
}
