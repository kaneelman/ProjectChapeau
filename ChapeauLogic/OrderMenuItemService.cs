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

        public void InsertOrderMenuItem(OrderMenuItem orderMenuItem)
        {
            orderMenuItemDB.InsertOrderMenuItemDB(orderMenuItem);
        }

        public void ChangeQuantityOrderMenuItem(OrderMenuItem orderMenuItem)
        {
            orderMenuItemDB.ChangeQuantityOrderMenuItemDB(orderMenuItem);
        }

        public void ChangeOrderMenuItemStatus(List<OrderMenuItem> orderMenuItems)
        {
            orderMenuItemDB.ChangeOrderMenuItemStatusDB(orderMenuItems);
        }
    }
}
