using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Company : Entity
    {
        public string CompanyName { get; set; } = string.Empty;

        public string CompanyDescription { get; set; } = string.Empty;
        
        public ICollection<CompanyOffer> CompanyOffers { get; set; } = new List<CompanyOffer>();
    }
}
