using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CourseSources : Entity
    {
     
        public int CourseId {  get; set; }
        public Course Course { get; set; }

        public int InformationSourceId { get; set; }
        public InformationSource InformationSource { get; set; }
    }
}
