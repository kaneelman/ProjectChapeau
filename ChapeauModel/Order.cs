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

        public Order(int id, Employee employee, string comment, DiningTable table)
        {
            Id = id;
            HandledBy = employee;
            Comment = comment;
            Table = table;
            content = new List<OrderMenuItem>();
        }

        //Çonstructor for new orders, because the Id had yet to be generated
        public Order(Employee employee, string comment, DiningTable table)
        {
            HandledBy = employee;
            Comment = comment;
            Table = table;
            content = new List<OrderMenuItem>();
        }

        public void AddOrderItem(OrderMenuItem item)
        {
            content.Add(item);
        }

        public void AddOrderItems(List<OrderMenuItem> items)
        {
            foreach (OrderMenuItem item in items)
            {
                this.AddOrderItem(item);
            }
        }

        public List<OrderMenuItem> GetOrderMenuItems()
        {
            return this.content;
        }

    }
}
