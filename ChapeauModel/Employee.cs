using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public EmployeePosition Position { get; set; }

        public Employee(string id, string name, EmployeePosition position)
        {
            Id = id;
            Name = name;
            Position = position;
        }

        public Employee(string id, string name, string position)
        {
            Id = id;
            Name = name;

            switch (position)
            {
                case "Waiter":
                    Position = EmployeePosition.Waiter;
                    break;
                case "Bartender":
                    Position = EmployeePosition.Bartender;
                    break;
                case "Chef":
                    Position = EmployeePosition.Chef;
                    break;
                case "Manager":
                    Position = EmployeePosition.Manager;
                    break;
                default:
                    throw new Exception("Wrong string input for employee position");
            }
        }
    }
}
