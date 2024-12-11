using Tyuiu.SizikovSS.Sprint4.Task1.V29.Lib;

namespace Tyuiu.SizikovSS.Sprint4.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();

            int[] mass = [5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8];

            var res = ds.Calculate(mass);

            Assert.AreEqual(31, res);
        }
    }
}
