using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public int Id { get; set; }
        public Employee HandledBy { get; set; }
        public string Comment { get; set; }
        public DiningTable Table { get; set; }

        private List<OrderMenuItem> content;

        public Order()
        {
            content = new List<OrderMenuItem>();
        }

    }
}
