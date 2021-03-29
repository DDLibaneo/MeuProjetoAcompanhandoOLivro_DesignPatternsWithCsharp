using System;

namespace FlixOne.InventoryManagement
{
    public abstract class InventoryCommand
    {
        private readonly bool _isTerminatingCommand;

        protected IUserInterface UserInterface { get; }

        // O construtor é para as classes que vão herdar desta classe
        // abstrata.
        internal InventoryCommand(bool commandIsTerminating)
        {
            _isTerminatingCommand = commandIsTerminating;
        }

        internal InventoryCommand(bool commandIsTerminating, IUserInterface userInterface)
        {
            _isTerminatingCommand = commandIsTerminating;

            UserInterface = userInterface;
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

        internal string GetParameter(string parameterName)
        {
            return UserInterface.ReadValue($"Enter {parameterName}");
        }

        internal abstract bool InternalCommand();
    }
}
