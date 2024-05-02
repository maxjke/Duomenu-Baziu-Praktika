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
        public int BillingInformationId { get; set; }
        [ForeignKey("BillingInformationId")]
        public BillingInformation BillingInformation { get; set; }

        [Required]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }

}
