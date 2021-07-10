using FlixOne.Interfaces.InventoryManagementClient;

namespace FlixOne.InventoryManagementClient
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
    internal abstract class NonTerminatingCommand : InventoryCommand
    {
        protected NonTerminatingCommand() : base(commandIsTerminating: false) { }
    }
}