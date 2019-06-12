using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderMenuItemDAO : Base
    {
        //Create menuItemDB object
        MenuItemDAO menuItemDB = new MenuItemDAO();


        //Get all OrderMenuItems from the database
        public List<OrderMenuItem> GetAllOrderMenuItemsDB()
        {
            string query = "SELECT id, item_id, quantity, date_time, status, comment FROM ORDER_CONTENT";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get a list of OrderMenuItems from the database by the order id
        public List<OrderMenuItem> GetOrderMenuItemsByOrderIdDB(int itemId)
        {
            string query = "SELECT id, item_id, quantity, date_time, status, comment FROM ORDER_CONTENT WHERE order_id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", itemId)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public OrderMenuItem GetOrderMenuItemByIdentityDB(int id)
        {
            string query = "SELECT id, item_id, quantity, date_time, status, comment FROM ORDER_CONTENT WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }


        //Create OrderMenuItem in the database
        public void InsertOrderMenuItemsForOrderDB(List<OrderMenuItem> orderMenuItems, Order order)
        {
            string query = "";

            foreach (OrderMenuItem item in orderMenuItems)
            {
                query += $"INSERT INTO [ORDER_CONTENT] VALUES (@order_id, {item.GetMenuItem().Id}, {item.Quantity}, @date_time, {item.Status}, {item.Comment}) ";

            }

            SqlParameter[] sqlParameters = (new[]
            {
                    new SqlParameter("@order_id", order.Id),
                    new SqlParameter("@date_time", DateTime.Now),
            });

            ExecuteEditQuery(query, sqlParameters);
        }



        //Change status of OrderMenuItems for an order
        public void ChangeOrderMenuItemStatusDB(List<OrderMenuItem> orderMenuItems, OrderStatus status)
        {
            string query = "";

            foreach (OrderMenuItem item in orderMenuItems)
            {
                query += $"UPDATE ORDER_CONTENT SET status = @status WHERE id = {item.Id}"; // not sure if this works without the  ' ' around @status
            }

            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@status",  status.ToString()),
            });

            //Execute query and store the ID
            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveOrderMenuItemDB(OrderMenuItem orderMenuItem, int quantity)
        {
            string query = "";

            if (quantity < orderMenuItem.Quantity)
            {
                query = "UPDATE ORDER_CONTENT SET quantity = @quantity WHERE id = @id";
            } else if ( quantity == orderMenuItem.Quantity)
            {
                query = "DELETE ORDER_CONTENT WHERE id = @id";

            }
            else
            {
                throw new Exception("bla");
            }
        }

        //Convert OrderMenuItem information from the database to OrderMenuItem objects
        private List<OrderMenuItem> ReadTables(DataTable dataTable)
        {
            List<OrderMenuItem> orderMenuItems = new List<OrderMenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderMenuItem orderMenuItem = new OrderMenuItem(menuItemDB.GetMenuItemByIdDB((int)dr["item_id"]), (int)dr["id"],(DateTime)dr["date_time"], (int)dr["quantity"],(string)dr["comment"], (string)dr["status"]);
                orderMenuItems.Add(orderMenuItem);
            }
            return orderMenuItems;
        }

    }
}
