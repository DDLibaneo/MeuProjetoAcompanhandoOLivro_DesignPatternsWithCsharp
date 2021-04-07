using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagementTests.Models
{
    public class MockUserInterfaceObject
    {
        public List<Tuple<string, string>> ReadList { get; set; }

        public List<string> MessageList { get; set; }

        public List<string> WarningList { get; set; }
    }
}
