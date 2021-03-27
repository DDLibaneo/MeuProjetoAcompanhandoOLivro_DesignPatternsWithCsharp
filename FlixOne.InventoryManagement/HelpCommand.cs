using System;

namespace FlixOne.InventoryManagement
{
    internal class HelpCommand : NonTerminatingCommand
    {
        protected override bool InternalCommand()
        {
            Console.WriteLine("USAGE:");

            Console.WriteLine("\tadd inventory (a)");

            // ...

            Console.WriteLine("Examples:");

            // ...

            return true;
        }
    }
}
