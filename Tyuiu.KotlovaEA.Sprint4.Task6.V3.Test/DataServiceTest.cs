using Tyuiu.KotlovaEA.Sprint4.Task6.V3.Lib;
namespace Tyuiu.KotlovaEA.Sprint4.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var week = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

            int res = ds.Calculate(week);

            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
