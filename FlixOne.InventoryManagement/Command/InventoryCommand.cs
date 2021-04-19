using System;

namespace FlixOne.InventoryManagement.Command
{
    public abstract class InventoryCommand
    {
        private readonly bool _isTerminatingCommand;

        protected IUserInterface UserInterface { get; }

        // O construtor é para as classes que vão herdar desta classe
        // abstrata.
        protected InventoryCommand(bool commandIsTerminating, IUserInterface userInterface)
        {
            _isTerminatingCommand = commandIsTerminating;

            UserInterface = userInterface;
        }

        public (bool wasSuccessful, bool shouldQuit) RunCommand()
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

        protected abstract bool InternalCommand();

        internal string GetParameter(string parameterName)
        {
            return UserInterface.ReadValue($"Enter {parameterName}");
        }        
    }
}
