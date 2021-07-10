using FlixOne.InventoryManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FlixOne.InventoryManagementTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        private void AddInventoryCommand_Successful()
        {
            // создаем экземпл€р команды
            // добавл€ем новую книгу с параметром "name"
            // провер€ем, была ли добавлена книга с данным названием и количеством 0 
            Assert.Inconclusive("AddInventoryCommand_Successful has not been implemented");
        }
        [TestMethod]
        private void GetInventoryCommand_Successful() => Assert.Inconclusive("GetInventoryCommand_Successful has not been implemented");
        [TestMethod]
        private void HelpCommand_Successful() => Assert.Inconclusive("HelpCommand_Successful has not been implemented");
        [TestMethod]
        public void QuitCommand_Successful()
        {
            var expectedInterface = new Helpers.TestUserInterface(
                new List<Tuple<string, string>>(),  // ReadValue()
                new List<string>  // WriteMessage()
                {
                    "Thank you for using FlixOne Inventory Management System"
                },
                new List<string>()  // WriteWarning()
            );

            // create an instance of the command
            var command = new InventoryManagement.QuitCommand(expectedInterface);

            // add a new book with parameter "name"
            var result = command.RunCommand();

            expectedInterface.Validate();

            Assert.IsTrue(result.shouldQuit, "Quit is a terminating command.");
            Assert.IsTrue(result.wasSuccessful, "Quit did not complete Successfully.");
        }

    [TestMethod]
        private void UpdateQuantity_Successful() => Assert.Inconclusive("UpdateQuantity_Successful has not been implemented");
    }
}
