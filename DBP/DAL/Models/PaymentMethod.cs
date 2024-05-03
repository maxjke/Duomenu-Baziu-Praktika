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

        [Required]
        [ForeignKey("BillingInformation")]
        public int BillingInformationId { get; set; }
        
        public BillingInformation BillingInformation { get; set; }

        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        
        public Order Order { get; set; }
    }

}
