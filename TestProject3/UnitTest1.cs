using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             int[] mass = {-6,-9,2,8,3,-8,4,5,-4,6,-9,1,-5};
                        int mult = 1;
                        int mult1 = 5760;
                        int result = Lab23.Program.Product(mult,mass);
                        Assert.AreEqual(mult1,result);
        }
    }
}