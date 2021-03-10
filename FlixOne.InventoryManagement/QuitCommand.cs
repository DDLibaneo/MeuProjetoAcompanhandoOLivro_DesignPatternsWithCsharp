using System;

namespace FlixOne.InventoryManagement
{
    public class QuitCommand
    {
        public bool RunCommand(out bool shouldQuit)
        {
            Console.WriteLine("Thank you for using FlixOne Inventory Management System");

            shouldQuit = false;

            return true;
        }
    }


}
