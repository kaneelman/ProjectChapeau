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
    public class EmployeeDAO : Base
    {
        public List<Employee> GetEmployee()
        {
            string query = "SELECT id, name, position, password FROM EMPLOYEE";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetInfoEmployee(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Employee> GetInfoEmployee(DataTable dataTable)
        {
            List<Employee> Employees = new List<Employee>();

            foreach(DataRow dr in dataTable.Rows)
            {
                Employee workers = new Employee()
                {
                    Id = (int)dr["id"],
                    Name = (string)dr["name"],
                    Position = (EmployeePosition)dr["position"],
                    Password = (string)dr["password"]
                };
                Employees.Add(workers);
            }
            return Employees;
        }
    }
}
