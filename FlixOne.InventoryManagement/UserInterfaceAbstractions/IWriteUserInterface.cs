namespace FlixOne.InventoryManagement
{
    public interface IWriteUserInterface
    {
        void WriteMessage(string message);

        void WriteWarning(string message);
    }
}