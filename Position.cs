using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    internal class Position
    {
        public Employee Employee { get; set; }
        public string PositionName { get; set; }
        public decimal Salary { get; set; }

        public Position(Employee employee, string positionName, decimal salary)
        {
            Employee = employee;
            PositionName = positionName;
            Salary = salary;
        }
    }

   

}
