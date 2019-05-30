using System;
using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    public class EmployeeService
    {
        EmployeeDAO EmployeeDB = new EmployeeDAO();

        public List<Employee> GetEmployees()
        {
            return EmployeeDB.GetAllEmployeesDB();
        }

        public Employee GetEmployee(string id)
        {
            return EmployeeDB.GetEmployeeByIdDB(id);
        }

        public bool CheckUsername(string id)
        {
            return EmployeeDB.CheckUsernameDB(id);
        }

        public bool CheckPassword(string id, string password)
        {
            return EmployeeDB.CheckPasswordDB(id, password);
        }
    }
}
