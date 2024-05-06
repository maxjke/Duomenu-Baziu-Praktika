using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Review : Entity
    {
        public int ReviewRating { get; set; }

        public int Course_id {  get; set; }
    }
}
