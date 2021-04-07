using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlixOne.InventoryManagement;
using FlixOne.InventoryManagementTests.Helpers;
using FlixOne.InventoryManagementTests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlixOne.InventoryManagementTests.Helpers
{
    [TestClass]
    public class TestUserInterface : IUserInterface
    {
        private readonly List<Tuple<string, string>> _expectedReadRequests;
        private readonly List<string> _expectedWriteMessageRequests;
        private readonly List<string> _expectedWriteWarningRequests;

        private int _expectedReadRequestsIndex;
        private int _expectedWriteMessageRequestsIndex;
        private int _expectedWriteWarningRequestsIndex;

        public TestUserInterface(MockUserInterfaceObject mockUserInterfaceObj)
        {
            _expectedReadRequests = mockUserInterfaceObj.ReadList;
            _expectedWriteMessageRequests = mockUserInterfaceObj.MessageList;
            _expectedWriteWarningRequests = mockUserInterfaceObj.WarningList;
        }

        [TestMethod]
        public void WriteWarning(string message)
        {
            Assert.IsTrue(_expectedWriteWarningRequestsIndex < _expectedWriteWarningRequests.Count
                , "Received too many command write warning requests.");

            Assert.AreEqual(_expectedWriteWarningRequests[_expectedWriteWarningRequestsIndex++]
                , message
                , "Received unexpected command warning message");
        }

        [TestMethod]
        public void WriteMessage(string message)
        {
            Assert.IsTrue(_expectedWriteMessageRequestsIndex < _expectedWriteMessageRequests.Count
                , "Received too many command write message requests.");

            Assert.AreEqual(_expectedWriteMessageRequests[_expectedWriteMessageRequestsIndex++]
                , message
                , "Received unexpected command write message");
        }

        [TestMethod]
        public string ReadValue(string message)
        {
            Assert.IsTrue(_expectedReadRequestsIndex < _expectedReadRequests.Count
                , "Received too many command read requests.");

            Assert.AreEqual(_expectedReadRequests[_expectedReadRequestsIndex].Item1
                , "Received unexpected command read message.");

            return _expectedReadRequests[_expectedReadRequestsIndex++].Item2;
        }

        [TestMethod]
        public void Validate()
        {
            Assert.IsTrue(_expectedReadRequestsIndex == _expectedReadRequests.Count
                , "Not all read requests were performed.");

            Assert.IsTrue(_expectedWriteMessageRequestsIndex == _expectedWriteMessageRequests.Count
                , "Not all write message requests were performed.");

            Assert.IsTrue(_expectedWriteWarningRequestsIndex == _expectedWriteWarningRequests.Count
                , "Not all write warning requests were performed.");
        }
    }
}
