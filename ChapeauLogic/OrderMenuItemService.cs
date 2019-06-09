using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;


namespace ChapeauLogic
{
    public class OrderMenuItemService
    {
        OrderMenuItemDAO orderMenuItemDB = new OrderMenuItemDAO();

        public List<OrderMenuItem> GetAllOrderMenuItem()
        {
            return orderMenuItemDB.GetAllOrderMenuItemsDB();
        }

        public List<OrderMenuItem> GetOrderMenuItemsByOrder(int orderId)
        {
            return orderMenuItemDB.GetOrderMenuItemsByOrderIdDB(orderId);
        }

        public void InsertOrderMenuItem(List<OrderMenuItem> orderMenuItem, Order order)
        {
            orderMenuItemDB.InsertOrderMenuItemsForOrderDB(orderMenuItem, order);
        }

        public void ChangeOrderMenuItemStatus(List<OrderMenuItem> orderMenuItems, OrderStatus status)
        {
            orderMenuItemDB.ChangeOrderMenuItemStatusDB(orderMenuItems, status);
        }

    }
}
