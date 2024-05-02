using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Student : Entity
    {
        [ForeignKey("ContactInfo")]
        public int? ContactInfoId { get; set; }
        public ContactInfo? ContactInfo { get; set; }

        [Required]
        [ForeignKey("Group")]
        public int GroupId {  get; set; }
        public Group Group { get; set; }


        [ForeignKey("Consultation")]
        public int ConsulatitonId { get; set; }
        public Consultation Consultation { get; set; }

        public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();


    }
}
