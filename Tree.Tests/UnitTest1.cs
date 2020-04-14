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

        [TestMethod]
        public void AddWithRedUncleAndRedParent()
        {
            //������ ���������� ���� � ��������  � ���� �� ������ 
            //��� ���������� �������� "��� ������� ������� �������� ���� � ������."
            TreeAlgorithm tree = new TreeAlgorithm();

            tree.Add(56);//root black
            tree.Add(12);//red
            tree.Add(65);//red
            tree.Add(16);
            var result = tree.Root;
            Assert.AreEqual(56, result.Value);
            Assert.AreEqual(12, result.Left.Value);
            Assert.AreEqual(Color.B, result.Left.Colour);//���� ��������
            Assert.AreEqual(65, result.Right.Value);
            Assert.AreEqual(Color.B, result.Left.Colour);//���� ����
            Assert.AreEqual(16, result.Left.Right.Value);
        }
    }
}
