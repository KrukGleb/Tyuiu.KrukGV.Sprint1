
using Tyuiu.KrukGV.Sprint1.Task2.V8.Lib;

namespace Tyuiu.KrukGV.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.CalculatePerimetr(7, 31);

            Assert.AreEqual(76, res);
        }
    }
}
