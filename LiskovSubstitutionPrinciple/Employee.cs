using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Employee : BaseEmployee, IManaged
    {
        public IManager Manager { get; set; } = null;

        public void AssignManager(IManager manager)
        {
            Manager = manager;
        }

        public override void CalculatePerHourRate(int rank) 
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (2 * rank);
        }
    }
}
