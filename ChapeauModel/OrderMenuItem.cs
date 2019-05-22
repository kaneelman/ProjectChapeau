using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderMenuItem : MenuItem
    {
        public DateTime TimeStamp { get; set; }
        public OrderStatus Status { get; set; }
        public string Comment { get; set; }
    }
}
