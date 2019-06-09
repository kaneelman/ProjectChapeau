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
            string query = "SELECT id, handled_by, [table] FROM [ORDER]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get an Order from database by id
        public Order GetOrderByIdDB(int id)
        {
            string query = "SELECT id, handled_by, [table] FROM [ORDER] WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        //Get active Order from the database by table
        public Order GetActiveOrderByTableDB(DiningTable table)
        {
            string query = "SELECT id, handled_by, [table] FROM [ORDER] WHERE [table] = @table AND id NOT IN (SELECT order_id FROM PAYMENT)";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@table", table.Id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        } 



        //WORK IN PROGRESS
        public List<Order> GetKitchenBeingPreparedOrdersDB()
        {
            string query = "SELECT O.id, O.handled_by, O.[table], C.id FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE (M.category LIKE 'Lu%' OR M.category LIKE 'Di%') AND C.[status] = 'Prepared'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesByOrderStatus(ExecuteSelectQuery(query, sqlParameters));
        }


        public List<Order> GetKitchenReadyToServeOrdersDB()
        {
            string query = "SELECT O.id, O.handled_by, O.[table], C.id FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE (M.category LIKE 'Lu%' OR M.category LIKE 'Di%') AND C.[status] = 'ReadyToServe'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesByOrderStatus(ExecuteSelectQuery(query, sqlParameters));
        }


        public List<Order> GetKitchenServedOrdersDB()
        {
            string query = "SELECT O.id, O.handled_by, O.[table], C.id FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE (M.category LIKE 'Lu%' OR M.category LIKE 'Di%') AND C.[status] = 'Served'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesByOrderStatus(ExecuteSelectQuery(query, sqlParameters));
        }





        //WORK IN PROGRESS
        public List<Order> GetBarBeingPreparedOrdersDB()
        {
            string query = "SELECT O.id, O.handled_by, O.[table], C.id FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE M.category LIKE 'Dr%' AND C.[status] = 'Prepared'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesByOrderStatus(ExecuteSelectQuery(query, sqlParameters));
        }


        public List<Order> GetBarReadyToServeOrdersDB()
        {
            string query = "SELECT O.id, O.handled_by, O.[table], C.id FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE M.category LIKE 'Dr%' AND C.[status] = 'ReadyToServe'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesByOrderStatus(ExecuteSelectQuery(query, sqlParameters));
        }


        public List<Order> GetBarServedOrdersDB()
        {
            string query = "SELECT O.id, O.handled_by, O.[table], C.id FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE M.category LIKE 'Dr%' AND C.[status] = 'Served'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesByOrderStatus(ExecuteSelectQuery(query, sqlParameters));
        }







        //Create new Order in the database
        public void InsertOrderDB (Order order)
        {
            //SomeCode
            string query = "INSERT INTO [ORDER] VALUES (@handled_by, @table)" +
                "SELECT SCOPE_IDENTITY();";

            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@handled_by", order.HandledBy),
                new SqlParameter("@table", order.Table)
            });

            //Execute query and store the ID
            int identityId = ExecuteIdentityEditQuery(query, sqlParameters);

            string query2 = "";

            foreach(OrderMenuItem item in order.GetOrderMenuItems())
            {
                query2 += $"INSERT INTO [ORDER_CONTENT] VALUES (@order_id, {item.GetMenuItem().Id}, {item.Quantity}, @date_time, {item.Status}, {item.Comment}) ";

            }

            SqlParameter[] sqlParameters2 = (new[]
            {
                    new SqlParameter("@order_id", identityId ),
                    new SqlParameter("@date_time", DateTime.Now),
            });

            ExecuteEditQuery(query2, sqlParameters2);
        }





        //Convert Order information from database to Order objects
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order((int)dr["id"], employeeDB.GetEmployeeByIdDB((string)dr["handled_by"]), diningTableDB.GetDiningTableByIdDB((int)dr["table"]));
                order.AddOrderItems(orderMenuItemDB.GetOrderMenuItemsByOrderIdDB((int)dr["id"]));
                orders.Add(order);
            }
            return orders;
        }

        private List<Order> ReadTablesByOrderStatus(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            List<int> orderTracker = new List<int>();

            foreach (DataRow dr in dataTable.Rows)
            {
                if (!orderTracker.Contains((int)dr["O.id"]))
                {
                    orderTracker.Add((int)dr["O.id"]);
                    Order order = new Order((int)dr["O.id"], employeeDB.GetEmployeeByIdDB((string)dr["O.handled_by"]), diningTableDB.GetDiningTableByIdDB((int)dr["O.[table]"]));
                    orders.Add(order);
                }

                foreach (Order order in orders)
                {
                    if(order.Id == (int)dr["O.id"])
                    {
                        order.AddOrderItem(orderMenuItemDB.GetOrderMenuItemByIdentityDB((int)dr["C.id"]));
                        break;
                    }
                }              
            }
            return orders;
        }
    }
}
