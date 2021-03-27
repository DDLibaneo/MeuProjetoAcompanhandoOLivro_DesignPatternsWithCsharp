namespace FlixOne.InventoryManagement
{
    internal abstract class NonTerminatingCommand : InventoryCommand
    {
        protected NonTerminatingCommand() : base(commandIsTerminating: false) { }
    }
}
