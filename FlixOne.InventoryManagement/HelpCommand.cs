using System;

namespace FlixOne.InventoryManagement
{
    public class HelpCommand
    {
        public bool RunCommand(out bool shouldQuit)
        {
            Console.WriteLine("USAGE:");

            // ...

            Console.WriteLine("\taddinventory(a)");

            // ...

            Console.WriteLine("Examples:");

            shouldQuit = false;

            return true;
        }
    }    
}
