using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if(string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError("First Name");
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError("Last Name");
                return false;
            }

            return true;
        }
    }
}
