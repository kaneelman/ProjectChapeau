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
    public class PaymentDAO : Base
    {
        OrderDAO orderDB = new OrderDAO();

        public List<Payment> GetAllPaymentsDB()
        {
            string query = "SELECT order_id, total, tip, paid_amount, method FROM PAYMENT AS P JOIN ORDER AS O ON order_id = O.id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Payment GetPaymentByOrder(Order order)
        {
            string query = "SELECT order_id, total, tip, paid_amount, method FROM PAYMENT AS P JOIN ORDER AS O ON order_id = O.id WHERE order_id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", order.Id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Payment> ReadTables(DataTable dataTable)
        {
            List<Payment> payments = new List<Payment>();

            foreach (DataRow dr in dataTable.Rows)
            {
                // Will continue here when OrderDAO is done

                Payment payment; // = new Payment(new Order());
                payments.Add(payment);
            }
            return payments;
        }
    }
}
