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

        public Employee GetEmployee(int id)
        {
            return EmployeeDB.GetEmployeeByIdDB(id);
        }
    }
}
