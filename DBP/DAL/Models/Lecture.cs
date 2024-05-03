using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Lecture : Entity 
    {
        [Required]
        [MaxLength(100)]
        public string LectureName { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        public string? Video {  get; set; }
        [Required]
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set;}

        [ForeignKey("Schedule")]
        public int ScheduleId {  get; set; }

        public Schedule Schedule { get; set; }

    }
}
