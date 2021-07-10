using FlixOne.Interfaces.InventoryManagement;
using FlixOne.InventoryManagement.Interfaces;

namespace FlixOne.InventoryManagement
{
    public abstract class InventoryCommand
    {
        private readonly bool _isTerminatingCommand;
        protected IUserInterface Interface { get; }
        internal InventoryCommand(bool commandIsTerminating, IUserInterface userInteface)
        {
            _isTerminatingCommand = commandIsTerminating;
            Interface = userInteface;
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

        internal string GetParameter(string parameterName)
        {
            return Interface.ReadValue($"Enter {parameterName}:");
        }

        internal abstract bool InternalCommand();
    }
}