using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Lecture : Entity 
    { 
    
        public string LectureName { get; set; } = string.Empty;
        
        public string Description { get; set; } = string.Empty;

        public string? Video {  get; set; }

        public int courseId { get; set; }

        public Course Course { get; set;}
    }
}
