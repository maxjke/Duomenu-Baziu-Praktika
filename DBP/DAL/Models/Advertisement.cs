using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Advertisement : Entity
    {
        public string Descrtiption { get; set; } = string.Empty;

        [Required]
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }`

    }
}
