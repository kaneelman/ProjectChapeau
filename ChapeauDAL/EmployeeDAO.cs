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
    public class EmployeeDAO : Base
    {
        //Get all Employees from the database
        public List<Employee> GetAllEmployeesDB()
        {
            string query = "SELECT id, name, position FROM EMPLOYEE";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get Employee from database by the id
        public Employee GetEmployeeByIdDB(string id)
        {
            string query = "SELECT id, name, position FROM EMPLOYEE WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        //check if user exists
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

        //Check if password fits the user
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

        //No sure if this will be used, no service yet
        public Employee GetEmployeeByCodeDB(string password)
        {
            string query = "SELECT id, name, position FROM EMPLOYEE WHERE password = @password";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@password", password)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        //Convert Employee information from database into Employee objects
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> Employees = new List<Employee>();

            foreach(DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee((string)dr["id"], (string)dr["name"], (string)dr["position"]);
                Employees.Add(employee);
            }
            return Employees;
        }
    }
}
