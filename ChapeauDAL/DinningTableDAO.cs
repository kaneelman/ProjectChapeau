using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;//added this to use the model library -stephen
using System.Data;// to use the datable
using System.Data.SqlClient;// for the query

namespace ChapeauDAL
{
    public class DinningTableDAO : Base
    {
        public List<DiningTable> GetTables()
        {
            string query = "SELECT id, status FROM DINING_TABLE ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetInfoTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<DiningTable> GetInfoTable (DataTable dataTable)
        {
            List<DiningTable> Tables = new List<DiningTable>();

            foreach (DataRow dr in dataTable.Rows)
            {
                DiningTable DinningTable = new DiningTable()
                {
                    Id = (int)dr["id"],
                    Status = (TableStatus)dr["status"]
                };
                Tables.Add(DinningTable);
            }

            return Tables;
        }
    }
}
