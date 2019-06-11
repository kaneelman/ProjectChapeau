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



        // Generic method to get orders from the database depending on the status
        public List<Order> BaseGetOrderByStatus(string type, string status)
        {
            string query;

            switch (type)
            {
                case "bar":
                    query = "SELECT O.id AS OrderId, C.date_time as [DateTime], handled_by, [table], C.id AS ContentId FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE M.category LIKE 'Dr%' AND C.[status] = @status ORDER BY C.date_time";
                    break;
                case "kitchen":
                    query = "SELECT O.id AS OrderId, C.date_time as [DateTime], handled_by, [table], C.id AS ContentId FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE (M.category LIKE 'Lu%' OR M.category LIKE 'Di%') AND C.[status] = @status ORDER BY C.date_time";
                    break;
                default:
                    throw new Exception("incorrect input for type");
            }

            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@status", status)
            });

            return ReadTablesByOrderStatus(ExecuteSelectQuery(query, sqlParameters));
        }
    



        // methods to get kitchen orders from the database depending on status
        public List<Order> GetKitchenBeingPreparedOrdersDB()
        {
            return BaseGetOrderByStatus("kitchen", "BeingPrepared");
        }


        public List<Order> GetKitchenReadyToServeOrdersDB()
        {
            return BaseGetOrderByStatus("kitchen", "ReadyToServe");
        }


        public List<Order> GetKitchenServedOrdersDB()
        {
            return BaseGetOrderByStatus("kitchen", "Served");
        }





        // methods to get bar orders from the database depending on status
        public List<Order> GetBarBeingPreparedOrdersDB()
        {
            return BaseGetOrderByStatus("bar", "BeingPrepared");
        }


        public List<Order> GetBarReadyToServeOrdersDB()
        {
            return BaseGetOrderByStatus("bar", "ReadyToServe");
        }


        public List<Order> GetBarServedOrdersDB()
        {
            return BaseGetOrderByStatus("bar", "Served");
        }



        //method to create a special search request from the database based on datetime and ordernumber
        public List<Order> GetKitchenBeingPreparedSpecialOrdersDB(DateTime time, int orderid)
        {
            string query = "SELECT O.id AS OrderId, C.date_time as [DateTime], handled_by, [table], C.id AS ContentId FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE(M.category LIKE 'Lu%' OR M.category LIKE 'Di%') AND C.order_id = @orderid AND C.date_time = @datetime";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@orderid", orderid),
                new SqlParameter("@datetime", time)
            });

            return ReadTablesByOrderStatus(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetBarBeingPreparedSpecialOrdersDB(DateTime time, int orderid)
        {
            string query = "SELECT O.id AS OrderId, C.date_time as [DateTime], handled_by, [table], C.id AS ContentId FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE M.category LIKE 'Dr%' AND C.order_id = @orderid AND C.date_time = @datetime";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@orderid", orderid),
                new SqlParameter("@datetime", time)
            });

            return ReadTablesByOrderStatus(ExecuteSelectQuery(query, sqlParameters));
        }

        
            //Create new Order in the database
            public void InsertOrderDB (Order order)
        {
            string query = "INSERT INTO [ORDER] VALUES (@handled_by, @table)" +     // Don't touch this please
                "SELECT SCOPE_IDENTITY();";

            //string query = "INSERT INTO [ORDER] VALUES (@id, @handled_by, @table)" +
            // "SELECT SCOPE_IDENTITY();";                                                   //This is the exact sequence of the order colunms  
                                                                                            
                                                                        
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", order.Id ),
                new SqlParameter("@handled_by", order.HandledBy.Id),
                new SqlParameter("@table", order.Table.Id)
            });

            //Execute query and store the ID
            int identityId = ExecuteIdentityEditQuery(query, sqlParameters);

            string query2 = "";

            foreach(OrderMenuItem item in order.GetOrderMenuItems())
            {
                query2 += $"INSERT INTO [ORDER_CONTENT] VALUES (@order_id, {item.GetMenuItem().Id}, {item.Quantity}, @date_time, {item.Status.ToString()}, {item.Comment}) ";
            }


            SqlParameter[] sqlParameters2 = (new[]
            {
                    new SqlParameter("@order_id", identityId ),
                    new SqlParameter("@date_time", DateTime.Now),
            });

            ExecuteEditQuery(query2, sqlParameters2);
        }


        
        //generic method to alter status in the database based on datetime
        public void BaseUpdateStatusDB(string type, DateTime time)
        {
            string query;

            switch (type)
            {
                case "bar":
                    query = "UPDATE ORDER_CONTENT SET STATUS = 'ReadyToServe' FROM ORDER_CONTENT AS OC JOIN MENU_ITEM AS MI ON MI.id = OC.item_id WHERE date_time = '@time' AND MI.category LIKE 'Dr%'";
                    break;
                case "kitchen":
                    query = "UPDATE ORDER_CONTENT SET STATUS = 'ReadyToServe' FROM ORDER_CONTENT AS OC JOIN MENU_ITEM AS MI ON MI.id = OC.item_id WHERE date_time = '@time' AND (MI.category LIKE 'Lu%' OR MI.category LIKE 'Di%')";
                    break;
                default:
                    throw new Exception("incorrect input for type");
            }

            SqlParameter[] sqlParameters = (new[]
{
                new SqlParameter("@time", time)
            });

            ExecuteEditQuery(query, sqlParameters);
        }

        //methods to alter status in the database based on datetime
        public void UpdateBarStatusDB(DateTime time)
        {
            BaseUpdateStatusDB("bar", time);
        }

        public void UpdateKitchenStatusDB(DateTime time)
        {
            BaseUpdateStatusDB("kitchen", time);
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

        //To check order status, a very different query is used, and thus a different read table
        private List<Order> ReadTablesByOrderStatus(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            List<int> orderTracker = new List<int>();

            foreach (DataRow dr in dataTable.Rows)
            {
                if (!orderTracker.Contains((int)dr["OrderId"]))
                {
                    orderTracker.Add((int)dr["OrderId"]);
                    Order order = new Order((int)dr["OrderId"], employeeDB.GetEmployeeByIdDB((string)dr["handled_by"]), diningTableDB.GetDiningTableByIdDB((int)dr["table"]));
                    orders.Add(order);
                }

                foreach (Order order in orders)
                {
                    if(order.Id == (int)dr["OrderId"])
                    {
                        order.AddOrderItem(orderMenuItemDB.GetOrderMenuItemByIdentityDB((int)dr["ContentId"]));
                        break;
                    }
                }              
            }
            return orders;
        }
    }
}
