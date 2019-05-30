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
    public class DiningTableDAO : Base
    {
        public List<DiningTable> GetAllTables()
        {
            string query = "SELECT id, status FROM DINING_TABLE ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<DiningTable> ReadTables (DataTable dataTable)
        {
            List<DiningTable> Tables = new List<DiningTable>();

            foreach (DataRow dr in dataTable.Rows)
            {
                DiningTable DiningTable = new DiningTable((int)dr["id"], (string)dr["status"]);
                Tables.Add(DiningTable);
            }

            return Tables;
        }
    }
}
