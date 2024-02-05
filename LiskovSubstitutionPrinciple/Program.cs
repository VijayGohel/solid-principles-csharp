using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new Manager();
            accountingVP.FirstName = "John";
            accountingVP.LastName = "Doe";
            accountingVP.CalculatePerHourRate(4);

            IManaged employee = new Manager();
            employee.FirstName = "Tim";
            employee.LastName = "Corey";
            employee.CalculatePerHourRate(2);
            employee.AssignManager(accountingVP);
            //employee.GeneratePerformanceReview();
            
            Console.WriteLine($"{employee.FirstName}'s salary is {employee.Salary}/hour");

            Console.ReadLine();
        }
    }
}
