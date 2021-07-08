namespace FlixOne.InventoryManagementClient
{
    public abstract class InventoryCommand
    {
        private readonly bool _isTerminatingCommand;
        internal InventoryCommand(bool commandIsTerminating) => _isTerminatingCommand = commandIsTerminating;
        public bool RunCommand(out bool shouldQuit)
        { 
            shouldQuit = _isTerminatingCommand; 
            return InternalCommand(); 
        }
        internal abstract bool InternalCommand();
    }
}