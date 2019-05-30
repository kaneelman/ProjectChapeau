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
        public List<Employee> GetAllEmployeesDB()
        {
            string query = "SELECT id, name, position FROM EMPLOYEE";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Employee GetEmployeeByIdDB(int id)
        {
            string query = "SELECT id, name, position FROM EMPLOYEE WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public bool CheckUsernameDB(string id)
        {
            string query = "SELECT id FROM EMPLOYEE WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });

            
            if(ReadTables(ExecuteSelectQuery(query, sqlParameters)).Count == 0)
            {
                return false;
            }
            return true;
        }

        public bool CheckPasswordDB(string id, string password)
        {
            string query = "SELECT id, password FROM EMPLOYEE WHERE id = @id AND password = @password";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@password", password)
            });


            if (ReadTables(ExecuteSelectQuery(query, sqlParameters)).Count == 0)
            {
                return false;
            }
            return true;
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> Employees = new List<Employee>();

            foreach(DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee((int)dr["id"], (string)dr["name"], (string)dr["position"]);
                Employees.Add(employee);
            }
            return Employees;
        }
    }
}
