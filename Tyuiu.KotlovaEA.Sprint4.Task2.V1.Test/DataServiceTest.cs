using Tyuiu.KotlovaEA.Sprint4.Task2.V1.Lib;
namespace Tyuiu.KotlovaEA.Sprint4.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 4, 6, 3, 5 };

            int res = ds.Calculate(numsArray);

            int wait = 48;

            Assert.AreEqual(wait, res);
        }
    }
}
