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
            string query = "SELECT item_id, quantity, date_time, status, comment FROM ORDER_CONTENT";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get a list of OrderMenuItems from the database by the order id
        public List<OrderMenuItem> GetOrderMenuItemsByOrderIdDB(int id)
        {
            string query = "SELECT item_id, quantity, date_time, status, comment FROM ORDER_CONTENT WHERE order_id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Convert OrderMenuItem information from the database to OrderMenuItem objects
        private List<OrderMenuItem> ReadTables(DataTable dataTable)
        {
            List<OrderMenuItem> orderMenuItems = new List<OrderMenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderMenuItem orderMenuItem = new OrderMenuItem(menuItemDB.GetMenuItemByIdDB((int)dr["item_id"]), (DateTime)dr["date_time"], (string)dr["comment"], (string)dr["status"]);
                orderMenuItems.Add(orderMenuItem);
            }
            return orderMenuItems;
        }

    }
}
