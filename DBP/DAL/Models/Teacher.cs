using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Teacher : Entity
    {
        [ForeignKey("ContactInfo")]
        public int? ContactInfoId { get; set; }
        public ContactInfo? ContactInfo { get; set; }

        [Required]
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        [ForeignKey("Consultation")]
        public int ConsulatitonId {  get; set; }

        public Consultation Consultation { get; set; }

        
    }
}
