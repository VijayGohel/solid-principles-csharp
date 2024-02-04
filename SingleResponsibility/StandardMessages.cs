using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public static class StandardMessages
    {
        public static void WelComeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press Enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string field)
        {
            Console.WriteLine($"You did not give correct value for {field}");
        }
    }
}
