namespace FlixOne.InventoryManagement.Command
{
    public abstract class NonTerminatingCommand : InventoryCommand
    {
        protected NonTerminatingCommand(IUserInterface userInterface) 
            : base(false, userInterface) { }
    }
}
