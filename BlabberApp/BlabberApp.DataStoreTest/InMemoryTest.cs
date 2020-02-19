using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class InMemoryTest
    {
        [TestMethod]
        public void TestCreateReadDeleteUpdate()
        {
            //Arrange
            InMemory harness = new InMemory();
            string expected = "This is a test";
            harness.setMessage("This is a test");

            //Act
            string actual = harness.getMessage();

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
