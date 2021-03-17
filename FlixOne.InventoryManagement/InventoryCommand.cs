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
        internal InventoryCommand(bool commandIsTerminating)
        {
            _isTerminatingCommand = commandIsTerminating;
        }

        public bool RunCommmand(out bool shouldQuit)
        {
            shouldQuit = _isTerminatingCommand;

            return InternalCommand();
        }

        internal abstract bool InternalCommand();
    }
}
