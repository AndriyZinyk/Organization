using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    internal class Employee
    {
        string firstName, lastName;
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void ReturnInfo()
        {
            Console.WriteLine($"Employee {firstName} {lastName}");
        }
    }
}
