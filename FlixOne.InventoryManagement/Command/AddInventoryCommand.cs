using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement.Command
{
    public class AddInventoryCommand : NonTerminatingCommand, IParameterisedCommand
    {
        public string InventoryName { get; set; }

        public AddInventoryCommand(IUserInterface userInterface) 
            : base(userInterface) { }

        /// <summary>
        /// AddInventoryCommand requires name
        /// </summary>
        /// <returns></returns>
        public bool GetParameters()
        {
            if (string.IsNullOrWhiteSpace(InventoryName))
                InventoryName = GetParameter("name");

            return !string.IsNullOrWhiteSpace(InventoryName);
        }

        protected override bool InternalCommand()
        {
            throw new NotImplementedException();
        }
    }
}
