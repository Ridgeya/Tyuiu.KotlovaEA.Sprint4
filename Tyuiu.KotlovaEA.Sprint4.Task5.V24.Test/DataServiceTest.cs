using Tyuiu.KotlovaEA.Sprint4.Task5.V24.Lib;
namespace Tyuiu.KotlovaEA.Sprint4.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[3, 3]
            {
                { 1, -2, 3 },
                { -4, 5, -6 },
                { 7, -8, 0 }
            };

            int res = ds.Calculate(mtrx);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
