using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeePosition Position { get; set; }
    }
}
