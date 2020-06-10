using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] mass = {-6,-9,2,8,3,-8,4,5,-4,6,-9,1,-5};
            int sum = 0;
            int sum1 = -8;
            int k = 11;
            int result=Lab23.Program.Sum(mass,k,sum);
            Assert.AreEqual(sum1,result);
        }
    }
}