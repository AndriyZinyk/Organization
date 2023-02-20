using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    internal class Organization
    {
        public List<Position> PositionList { get; set; } = null;
        public string OrganizationName { get; set; }
        public decimal Budget { get; set;}
        
        public void SalaryPayment()
        {
            foreach(Position p in PositionList)
            {
                Console.WriteLine($"{p.Employee.FirstName} {p.Employee.LastName} get {p.Salary:F2}");
                Budget -= p.Salary;
            }
            Console.WriteLine();
            Console.WriteLine($"After all salary payments were made budget equals {Budget:F2}.");            
        }

        public int ProjectIncome(string projectName)
        {
            int projectIncome = 0;
            bool valueParse = false;
            while (!valueParse)
            {
                Console.Write("Input project income sum: ");
                valueParse = Int32.TryParse(Console.ReadLine(), out projectIncome);

                if (!valueParse)
                    Console.WriteLine("Must be integer value, please try again");
            }

            return projectIncome;
        }

        public Organization(string organizationName, decimal budget)
        {
            OrganizationName = organizationName;
            Budget = budget;
        }
    }
}
