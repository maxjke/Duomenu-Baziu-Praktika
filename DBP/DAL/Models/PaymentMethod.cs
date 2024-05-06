using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PaymentMethod : Entity
    {
        public string PaymentMethodName { get; set; } = string.Empty;

        public int order_id { get; set; }
        
        public Order Order { get; set; }
    }

}
