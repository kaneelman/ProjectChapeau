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
    public class OrderDAO : Base
    {
        EmployeeDAO employeeDB = new EmployeeDAO();
        DiningTableDAO diningTableDB = new DiningTableDAO();
        OrderMenuItemDAO orderMenuItemDB = new OrderMenuItemDAO();

        public List<Order> GetAllOrdersDB()
        {
            string query = "SELECT id, handled_by, comment, [table] FROM [ORDER]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Order GetOrderByIdDB(int id)
        {
            string query = "SELECT id, handled_by, comment, [table] FROM [ORDER] WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public Order GetActiveOrderByTableDB(DiningTable table)
        {
            string query = "SELECT id, handled_by, comment, [table] FROM [ORDER] WHERE [table] = @table AND id NOT IN (SELECT order_id FROM PAYMENT)";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@table", table.Id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order((int)dr["id"], employeeDB.GetEmployeeByIdDB((string)dr["handled_by"]), (string)dr["comment"], diningTableDB.GetDiningTableByIdDB((int)dr["table"]));
                order.AddOrderItems(orderMenuItemDB.GetOrderMenuItemsByOrderIdDB((int)dr["id"]));
            }
            return orders;
        }


    }
}
