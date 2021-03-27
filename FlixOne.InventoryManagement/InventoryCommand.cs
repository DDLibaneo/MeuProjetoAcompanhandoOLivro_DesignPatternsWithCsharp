using System;

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
            if (this is IParameterisedCommand parameterisedCommand)
            {
                var allParametersCompleted = false;

                while (allParametersCompleted == false)
                {
                    allParametersCompleted = parameterisedCommand.GetParameters();
                }
            }

            return (InternalCommand(), _isTerminatingCommand);
        }

        public string GetParameter(string parameter)
        {
            throw new NotImplementedException();
        }

        protected abstract bool InternalCommand();
    }
}
