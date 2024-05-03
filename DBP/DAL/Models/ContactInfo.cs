using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ContactInfo : Entity
    {
        public string FirstName {  get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        [ForeignKey("Teacher")]
        public int? TeacherId { get; set; }

       
        public virtual Student? Student { get; set; }

        
        public virtual Teacher? Teacher { get; set; }

    }
}
