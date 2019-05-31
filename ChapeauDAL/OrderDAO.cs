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
        //Create EmployeeDAO, DiningTableDAO and OrderMenuItemDAO objects
        EmployeeDAO employeeDB = new EmployeeDAO();
        DiningTableDAO diningTableDB = new DiningTableDAO();
        OrderMenuItemDAO orderMenuItemDB = new OrderMenuItemDAO();

        //Get all Orders from the database
        public List<Order> GetAllOrdersDB()
        {
            string query = "SELECT id, handled_by, comment, [table] FROM [ORDER]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get an Order from database by id
        public Order GetOrderByIdDB(int id)
        {
            string query = "SELECT id, handled_by, comment, [table] FROM [ORDER] WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        //Get active Order from the database by table
        public Order GetActiveOrderByTableDB(DiningTable table)
        {
            string query = "SELECT id, handled_by, comment, [table] FROM [ORDER] WHERE [table] = @table AND id NOT IN (SELECT order_id FROM PAYMENT)";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@table", table.Id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }



        //WORK IN PROGRESS
        public List<Order> GetKitchenBeingPreparedOrdersDB()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        public List<Order> GetKitchenReadyToServeOrderDB()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        public List<Order> GetKitchenServedOrderDB()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }





        //WORK IN PROGRESS
        public List<Order> GetBarBeingPreparedItemsDB()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        public List<Order> GetBarReadyToServeItemsDB()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        public List<Order> GetBarServedItemsDB()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Create new Order in the database
        public void InsertOrderDB (Order order)
        {

            //SomeCode

        }

        //Convert Order information from database to Order objects
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order((int)dr["id"], employeeDB.GetEmployeeByIdDB((string)dr["handled_by"]), (string)dr["comment"], diningTableDB.GetDiningTableByIdDB((int)dr["table"]));
                order.AddOrderItems(orderMenuItemDB.GetOrderMenuItemsByOrderIdDB((int)dr["id"]));
                orders.Add(order);
            }
            return orders;
        }




    }
}
