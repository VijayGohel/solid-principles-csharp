using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person person = new Person();

            Console.WriteLine("Enter first name:");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            person.LastName = Console.ReadLine();

            return person;
        }
    }
}
