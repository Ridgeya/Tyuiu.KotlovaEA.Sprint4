using Tyuiu.KotlovaEA.Sprint4.Task7.V21.Lib;
namespace Tyuiu.KotlovaEA.Sprint4.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 4;
            int columns = 3;
            string str = "425963128528";

            DataService ds = new DataService();

            int res = ds.Calculate(rows, columns, str);

            int wait = 32;

            Assert.AreEqual(wait, res);
        }
    }
}
