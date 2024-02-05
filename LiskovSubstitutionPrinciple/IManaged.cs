using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public interface IManaged : IEmployee
    {
        IManager Manager { get; set; }
        void AssignManager(IManager manager);
    }
}
