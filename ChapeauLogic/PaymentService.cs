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

    /// <summary>
    /// gerwin's idea that its nicer to do the calculations here, so that when the code is changed into a console app, the code is already there
    /// </summary>
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

        //make a method that collects all the order by table
    }
    //make a calculation methods..
}
