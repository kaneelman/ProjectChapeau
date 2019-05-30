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
    }
}
