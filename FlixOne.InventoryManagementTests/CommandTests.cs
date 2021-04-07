using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FlixOne.InventoryManagementTests.Helpers;
using FlixOne.InventoryManagementTests.Models;
using FlixOne.InventoryManagement;

namespace FlixOne.InventoryManagementTests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void AddInventoryCommand_Successful()
        {
            // create an instance of the command
            // add a new book with parameter "name"
            // verify the book was added with the given name 
            // with 0 quantity

            Assert.Inconclusive("AddInventoryCommand_Successful has not been implemented.");
        }

        [TestMethod]
        public void GetInventoryCommand_Successful()
        {
            Assert.Inconclusive("GetInventoryCommand_Successful has not been implemented.");
        }

        [TestMethod]
        public void HelpCommand_Successful()
        {
            Assert.Inconclusive("HelpCommand_Successful has not been implemented.");
        }

        [TestMethod]
        public void QuitCommand_Successful()
        {
            var mockUserInterfaceObj = new MockUserInterfaceObject()
            {
                ReadList = new List<Tuple<string, string>>(),
                MessageList = new List<string>()
                {
                    "Thank you for using FlixOne Inventory Management System"
                },
                WarningList = new List<string>()
            };

            var expectedInterface = new TestUserInterface(mockUserInterfaceObj);

            // create an instance of the command
            var command = new QuitCommand(expectedInterface);

            // add a new book with parameter "name"
            var (wasSuccessful, shouldQuit) = command.RunCommand();

            expectedInterface.Validate();

            Assert.IsTrue(shouldQuit, "Quit is a terminating command.");
            Assert.IsTrue(wasSuccessful, "Quit did not complete Successfully.");
        }

        [TestMethod]
        public void UpdateQuantity_Successful()
        {
            Assert.Inconclusive("UpdateQuantity_Successful has not been implemented.");
        }
    }
}
