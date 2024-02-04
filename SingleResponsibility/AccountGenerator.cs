using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class AccountGenerator
    {
        public static string Generate(Person person)
        {
            string fullName = $"{person.FirstName} {person.LastName}";
            Console.WriteLine($"Your full name is: {fullName}");

            return fullName;
        }
    }
}
