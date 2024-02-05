using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey"},
                new ManagerModel { FirstName = "Vijay", LastName = "Gohel" },
                new ExecutiveModel { FirstName = "John", LastName = "Doe"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach(var applicant in applicants)
            {
                employees.Add(applicant.AccountProcessor.Create(applicant));
            }

            foreach(var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.EmailAddress} IsManager:{employee.IsManager} IsExecutive:{employee.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
