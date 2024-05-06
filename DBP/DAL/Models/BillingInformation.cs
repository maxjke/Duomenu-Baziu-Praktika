using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BillingInformation : Entity
    {
        public string CardNumber { get; set; } = string.Empty;
        public string CardHolderName { get; set; } = string.Empty;
        public string ExpireDate { get; set; } = string.Empty;

        public int paymentMethod_id;
      
    }
}

