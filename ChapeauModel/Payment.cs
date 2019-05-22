using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Payment
    {
        public Order Order { get; set; }
        public decimal Total { get; set; }
        public decimal Tip { get; set; }
        public decimal AmountPaid { get; set; }
        public PaymentMethod Method { get; set; } 

    }
}
