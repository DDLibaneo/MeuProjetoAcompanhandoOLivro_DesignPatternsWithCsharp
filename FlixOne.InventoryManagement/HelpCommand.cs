using System;

namespace FlixOne.InventoryManagement
{
    public class HelpCommand : InventoryCommand
    {
        public HelpCommand() : base(false) { }

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
