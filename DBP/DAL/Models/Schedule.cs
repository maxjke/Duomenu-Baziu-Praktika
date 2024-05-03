using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Schedule : Entity
    {
        public string LectureDate { get; set; } = string.Empty;

        public string LectureTime {  get; set; } = string.Empty;

        public  Lecture Lecture { get; set; }
    }
}
