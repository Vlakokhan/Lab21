using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x= 0 ;
            double y= 0 ;
            double result = Lab22.Program.Calculation(x);
            Assert.AreEqual(y,result);
        }
    }
}