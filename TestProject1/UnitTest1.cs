using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int number = 3;
            string c = "жовтий";
            string result = Lab21.Program.Number(number);
            Assert.AreEqual(c,result);
        }
    }
}