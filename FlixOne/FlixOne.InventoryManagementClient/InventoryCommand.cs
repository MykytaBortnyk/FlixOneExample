using FlixOne.Interfaces.InventoryManagementClient;

namespace FlixOne.InventoryManagementClient
{
    public abstract class InventoryCommand
    {
        private readonly bool _isTerminatingCommand;
        internal InventoryCommand(bool commandIsTerminating) => _isTerminatingCommand = commandIsTerminating;
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
        internal abstract bool InternalCommand();
    }
    internal abstract class NonTerminatingCommand : InventoryCommand
    {
        protected NonTerminatingCommand() : base(commandIsTerminating: false) { }
    }
}