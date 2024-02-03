using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DependencyInversion
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            IPerson person = new Person();
            return person;
        }

        public static IChore CreateChore()
        {
            IChore chore = new Chore(CreateLogger(), CreateMessageSender());
            return chore;
        }

        public static ILogger CreateLogger()
        {
            ILogger logger = new Logger();
            return logger;
        }

        public static IMessageSender CreateMessageSender()
        {
            IMessageSender messageSender = new Emailer();
            return messageSender;
        }
    }
}
