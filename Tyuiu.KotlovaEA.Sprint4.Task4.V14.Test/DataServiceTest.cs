using Tyuiu.KotlovaEA.Sprint4.Task4.V14.Lib;
namespace Tyuiu.KotlovaEA.Sprint4.Task4.V14.Test
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
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] wait = new int[3, 3]
            {
                { 0, 2, 0 },
                { 4, 0, 6 },
                { 0, 8, 0 }
            };

            int[,] res = ds.Calculate(mtrx);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
