using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    public class DiningTableService
    {
        DiningTableDAO diningTableDAO = new DiningTableDAO();

        public List<DiningTable> GetDiningTables()
        {

            List<DiningTable> diningTables = diningTableDAO.GetAllTables();
            return diningTables;

        }
    }
}
