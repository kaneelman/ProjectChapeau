using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;



namespace ChapeauLogic
{
    public class OrderService
    {
        OrderDAO orderDB = new OrderDAO();

        public List<Order> GetAllOrders()
        {
            return orderDB.GetAllOrdersDB();
        }

        public Order GetOrderById(int id)
        {
            return orderDB.GetOrderByIdDB(id);
        }

        public Order GetActiveOrderByTable(DiningTable diningTable)
        {
            return orderDB.GetActiveOrderByTableDB(diningTable);
        }

        //add order

        //delete order

        //check orders


    }
}
