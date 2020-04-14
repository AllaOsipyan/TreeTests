using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tree.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddRoot()
        {
            TreeAlgorithm tree = new TreeAlgorithm();
            
            tree.Add(35);
            var expectedColor = Color.B;
            var resultColor = tree.FindKey(35).Colour;
            Assert.AreEqual(expectedColor, resultColor);

        }
    }
}
