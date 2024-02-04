using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelComeMessage();

            Person person = PersonDataCapture.Capture();

            bool isValid = PersonValidator.Validate(person);

            if(!isValid) 
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.Generate(person);
            StandardMessages.EndApplication();
        }
    }
}
