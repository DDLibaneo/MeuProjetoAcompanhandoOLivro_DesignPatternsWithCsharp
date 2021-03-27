using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement
{
    public class ConsoleUserInterface
    {
        // read value from console
        public string ReadValue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(message);

            return Console.ReadLine();
        }

        // message to the console
        public void WriteMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        // writer warning message to the console
        public void WriteWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(message);
        }

        public void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(message);
        }
    }
}
