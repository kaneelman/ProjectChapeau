using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Collections.ObjectModel;


namespace ChapeauLogic
{
    public class PaymentService
    {
        PaymentDAO paymentDB = new PaymentDAO();

        public List<Payment> GetAllPayments()
        {
            return paymentDB.GetAllPaymentsDB();
        }

        public Payment GetPaymentByOrder(Order order)
        {
            return paymentDB.GetPaymentByOrder(order);
        }

        public void InsertPayment(Payment payment)
        {
            paymentDB.InsertPaymentDB(payment);
        }

    }
}
