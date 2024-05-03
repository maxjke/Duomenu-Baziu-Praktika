using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Certificate : Entity
    {
        public string CertificateName { get; set; } = string.Empty;

        public string CertificateDegree { get; set; } = string.Empty;

        public string ExpireDate {  get; set; } = string.Empty;

        [Required]
        [ForeignKey("Course")]
        public int? CourseId { get; set; }

        public virtual Course? Course { get; set; }
    }
}
