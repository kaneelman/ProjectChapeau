using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderMenuItem
    {
        private MenuItem item;

        public DateTime TimeStamp { get; set; }
        public string Comment { get; set; }
        public OrderStatus Status { get; set; }

        public OrderMenuItem(MenuItem item, DateTime timeStamp, string comment, OrderStatus status)
        {
            this.item = item;
            TimeStamp = timeStamp;
            Comment = comment;
            Status = status;
        }

        public OrderMenuItem(MenuItem item, DateTime timeStamp, string comment, string status)
        {
            this.item = item;
            TimeStamp = timeStamp;
            Comment = comment;

            switch (status)
            {
                case "BeingPrepared":
                    Status = OrderStatus.BeingPrepared;
                    break;
                case "ReadyToServe":
                    Status = OrderStatus.ReadyToServe;
                    break;
                case "Served":
                    Status = OrderStatus.Served;
                    break;
                default:
                    throw new Exception("Wrong string input for order status");
            }
        }
    }
}
