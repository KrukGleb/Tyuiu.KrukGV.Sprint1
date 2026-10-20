
using Tyuiu.KrukGV.Sprint1.Task3.V6.Lib;

namespace Tyuiu.KrukGV.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.TravelCost(67,  8.5,  6.5);

            Assert.AreEqual(74.04, res);
        }
    }
}
