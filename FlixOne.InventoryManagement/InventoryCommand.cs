using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement
{
    public abstract class InventoryCommand
    {
        private readonly bool _isTerminatingCommand;

        // O construtor é para as classes que vão herdar desta classe
        // abstrata.
        protected InventoryCommand(bool commandIsTerminating)
        {
            _isTerminatingCommand = commandIsTerminating;
        }

        public (bool wasSuccessful, bool shouldQuit) RunCommmand()
        {
            return (InternalCommand(), _isTerminatingCommand);
        }

        protected abstract bool InternalCommand();
    }
}
