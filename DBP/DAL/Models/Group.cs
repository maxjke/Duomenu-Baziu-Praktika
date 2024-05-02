using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Group : Entity
    { 
        public string GroupName { get; set; } = string.Empty;

        public ICollection<Student> Students { get; set; } = new List<Student>();



    }
}
