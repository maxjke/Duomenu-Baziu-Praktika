using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class InformationSource : Entity
    {
        public string InformationSourceName { get; set; } = string.Empty;

        public string InformationSourceType { get; set; } = string.Empty;

        public ICollection<CourseSources> CourseSources { get; set; } = new List<CourseSources>();

    }
}
