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

        //to get all the items ordered  from for the table
        OrderMenuItemDAO orderMenuItemDB = new OrderMenuItemDAO();

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
        
        //get all the order for a table selected
        public Order GetCompleteActiveOrderByTable(DiningTable diningTable)
        {
            Order order = orderDB.GetActiveOrderByTableDB(diningTable);
            order.AddOrderItems(orderMenuItemDB.GetOrderMenuItemsByOrderIdDB(order.Id));
            return order;
        }


        public List<Order> GetKitchenBeingPreparedOrders()
        {
            return orderDB.GetKitchenBeingPreparedOrdersDB();
        }

        public List<Order> GetKitchenReadyToServeOrders()
        {
            return orderDB.GetKitchenReadyToServeOrdersDB();
        }

        public List<Order> GetKitchenServedOrders()
        {
            return orderDB.GetKitchenServedOrdersDB();
        }
        


        public List<Order> GetBarBeingPreparedOrders()
        {
            return orderDB.GetBarBeingPreparedOrdersDB();
        }

        public List<Order> GetBarReadyToServeOrders()
        {
            return orderDB.GetBarReadyToServeOrdersDB();
        }

        public List<Order> GetBarServedORders()
        {
            return orderDB.GetBarServedOrdersDB();
        }

        public void InsertOrder(Order order)
        {
            orderDB.InsertOrderDB(order);
        }


    }
}
