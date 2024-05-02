using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Order : Entity
    {
        public string OrderNumber { get; set; } = string.Empty;
       
        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();
    }

}
