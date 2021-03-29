using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement
{
    public interface IUserInterface
    {
        string ReadValue(string message);

        void WriteMessage(string message);

        void WriteWarning(string message);

        void WriteError(string message);
    }
}
