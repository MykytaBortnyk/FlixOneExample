using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        private void QuitCommand_Successful() => Assert.Inconclusive("QuitCommand_Successful has not been implemented");
        [TestMethod]
        private void UpdateQuantity_Successful() => Assert.Inconclusive("UpdateQuantity_Successful has not been implemented");
    }
}
