using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement.Command
{
    public class GetInventoryCommand : NonTerminatingCommand
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userInterface"></param>
        public GetInventoryCommand(IUserInterface userInterface) 
            : base(userInterface) { }

        protected override bool InternalCommand()
        {
            throw new NotImplementedException("Implemented in next chapter!");
        }
    }
}
