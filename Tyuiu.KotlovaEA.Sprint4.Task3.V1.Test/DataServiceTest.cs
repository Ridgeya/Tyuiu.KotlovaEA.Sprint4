using Tyuiu.KotlovaEA.Sprint4.Task3.V1.Lib;
namespace Tyuiu.KotlovaEA.Sprint4.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5]
            {
                { 3, 4, 3, 4, 1 },
                { 8, 1, 6, 6, 9 },
                { 9, 8, 5, 1, 3 },
                { 1, 8, 7, 1, 2 },
                { 9, 9, 7, 5, 6 }
            };

            int res = ds.Calculate(mtrx);

            int wait = 21;

            Assert.AreEqual(wait, res);
        }
    }
}
