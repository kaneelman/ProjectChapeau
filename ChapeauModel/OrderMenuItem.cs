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
        public string Comment { get; set; }
        public OrderStatus Status { get; set; }

        public OrderMenuItem(DateTime timeStamp, string comment, OrderStatus status)
        {
            TimeStamp = timeStamp;
            Comment = comment;
            Status = status;
        }

        public OrderMenuItem(DateTime timeStamp, string comment, string status)
        {
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
