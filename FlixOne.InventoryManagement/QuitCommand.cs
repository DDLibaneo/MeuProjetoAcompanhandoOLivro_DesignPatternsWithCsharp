using System;

namespace FlixOne.InventoryManagement
{
    internal class QuitCommand : InventoryCommand
    {
        public QuitCommand() : base(true) { }

        public QuitCommand(IUserInterface userInterface) 
            : base(true, userInterface : userInterface) { }

        internal override bool InternalCommand()
        {
            UserInterface.WriteMessage("Thank you for using FlixOne Inventory Management System");

            return true;
        }
    }
}
