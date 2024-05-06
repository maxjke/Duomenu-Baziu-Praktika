using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Assignment : Entity
    {
        public string AssignmentInformation { get; set; } = string.Empty;

        public string AssignmentType { get; set; } = string.Empty;

        public int Lecture_id;
    }
}
