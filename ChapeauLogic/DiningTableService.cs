﻿using ChapeauDAL;
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
        DiningTableDAO diningTableDB = new DiningTableDAO();

        public List<DiningTable> GetDiningTables()
        {
            return diningTableDB.GetAllDiningTablesDB();
        }

        public DiningTable GetDiningTable(int id)
        {
            return diningTableDB.GetDiningTableByIdDB(id);
        }

        public void ChangeDiningTableStatus(DiningTable diningTable)
        {
            diningTableDB.ChangeDiningTableStatusDB(diningTable);
        }
    }
}
